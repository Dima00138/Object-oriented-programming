using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Xceed.Wpf.Toolkit;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace CourseWork
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly OracleDbContext _context;
        public readonly DbSet<T> _dbSet;
        protected readonly ObservableCollection<T> _entities;

        public Repository(OracleDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
            _entities = new ObservableCollection<T>();
        }

        public virtual void Create(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                _entities.Add(entity);
            }
            catch
            {
                MessageBox.Show("Error INSERT");
            }
        }

        public virtual void Update(T entity, string columnName, string newValue)
        {
        }

        public virtual void Delete(T entity, string id)
        {
        }

        public virtual T? Get(string id)
        {
            return null;
        }

        public IEnumerable<T> GetAll()
        {
            return _entities;
        }

        public async Task<T> GetByIdAsync(string id)
        {
            return await _dbSet.FindAsync(id);
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
    }

    public class SheduleRepository : Repository<Shedule>
    {
        public SheduleRepository(OracleDbContext context) : base(context)
        {
            using (OracleCommand command = new OracleCommand("SELECT * FROM SCHEDULE", _context.conn))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Shedule shedule = new Shedule(Convert.ToString(reader["ID"]), (string)reader["ID_TRAIN"], (DateTime)reader["DATE"],
                            Convert.ToInt32(reader["ROUTE"]),
                            (short)reader["TIME_IN_WAY"], (short)reader["FREQUENCY"]);
                        _entities.Add(shedule);
                    }
                }
            }
        }

        public override void Create(Shedule entity)
        {
            try
            {
                Shedule lastShedule = entity;
                string insertQuery = "INSERT INTO SCHEDULE (\"ID\", ID_TRAIN, \"DATE\", ROUTE, TIME_IN_WAY, FREQUENCY)" +
                                        " VALUES (:\"id\", :idtrain, :\"date\", :route, :tiw, :freq)";
                using (OracleCommand command = new OracleCommand(insertQuery, _context.conn))
                {
                    command.Parameters.Add(":\"id\"", Convert.ToInt32(lastShedule.id) + (int)DateTime.Now.Ticks);
                    command.Parameters.Add(":idtrain", lastShedule.Id_Train);
                    command.Parameters.Add(":\"date\"", lastShedule.Date);
                    command.Parameters.Add(":route", 1);
                    command.Parameters.Add(":tiw", lastShedule.Time_In_Way);
                    command.Parameters.Add(":freq", lastShedule.Frequency);
                    command.ExecuteNonQuery();
                }
                _entities.Add(entity);
            }
            catch
            {
                MessageBox.Show("Error INSERT");
            }
        }

        public override void Update(Shedule entity, string columnName, string newValue)
        {
            try
            {
                //_context.Entry(entity).State = EntityState.Modified;
                string updateQuery = $"UPDATE SCHEDULE SET {columnName.ToUpper()} = '{newValue}' WHERE \"ID\" = {entity.id}";
                using (OracleCommand command = new OracleCommand(updateQuery, _context.conn))
                {
                    command.ExecuteNonQuery();
                }
                _entities.Remove(entity);
                entity[$"{columnName}"] = newValue;
                _entities.Add(entity);
            }
            catch
            {
                MessageBox.Show("Вы не можете изменить это поле");
            }
        }

        public override void Delete(Shedule entity, string id)
        {
            try
            {
                string deleteQuery = $"DELETE SCHEDULE WHERE \"ID\" = {id}";
                using (OracleCommand command = new OracleCommand(deleteQuery, _context.conn))
                {
                    command.ExecuteNonQuery();
                }
                if (_entities.Contains(entity))
                {
                    _entities.Remove(entity);
                }
                _entities.Remove(entity);
            }
            catch
            {
                MessageBox.Show("Вы не можете удалить эту строку");
            }
        }

        public override Shedule? Get(string id)
        {
            return _entities.ToList().Find(item => item.id == id);
        }
    }

    //Route
    public class RouteRepository : Repository<Route>
    {
        public RouteRepository(OracleDbContext context) : base(context)
        {
            using (OracleCommand command = new OracleCommand("SELECT * FROM ROUTES", _context.conn))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Route route = new Route((string)reader["ARRIVAL_POINT"], (string)reader["DEPARTURE_POINT"]);

                        _entities.Add(route);
                    }
                }
            }
        }

        public override void Create(Route entity)
        {
            try
            {
                string insertQuery = "INSERT INTO ROUTES (\"ID\", DEPARTURE_POINT, ARRIVAL_POINT, INTERMEDIATE_POINTS)" +
                                        " VALUES (:\"id\", :depps, :arp, :imp)";
                using (OracleCommand command = new OracleCommand(insertQuery, _context.conn))
                {
                    command.Parameters.Add(":\"id\"", Convert.ToInt32(entity.id));
                    command.Parameters.Add(":depps", entity.Departure_Point);
                    command.Parameters.Add(":arp", entity.Arrival_Point);
                    command.Parameters.Add(":imp", "VPOINTS('1')");
                    command.ExecuteNonQuery();
                }
                _entities.Add(entity);
            }
            catch
            {
                MessageBox.Show("Error INSERT");
            }
        }

        public override void Update(Route entity, string columnName, string newValue)
        {
            try
            {
                //_context.Entry(entity).State = EntityState.Modified;
                string updateQuery = $"UPDATE ROUTES SET {columnName.ToUpper()} = '{newValue}' WHERE \"ID\" = {entity.id}";
                using (OracleCommand command = new OracleCommand(updateQuery, _context.conn))
                {
                    command.ExecuteNonQuery();
                }
                _entities.Add(entity);
            }
            catch
            {
                MessageBox.Show("Вы не можете изменить это поле");
            }
        }

        public override void Delete(Route entity, string id)
        {
            try
            {
                string deleteQuery = $"DELETE ROUTES WHERE \"ID\" = {id}";
                using (OracleCommand command = new OracleCommand(deleteQuery, _context.conn))
                {
                    command.ExecuteNonQuery();
                }
                if (_entities.Contains(entity))
                {
                    _entities.Remove(entity);
                }
                _entities.Remove(entity);
            }
            catch
            {
                MessageBox.Show("Вы не можете удалить эту строку");
            }
        }

        public Route? Get(int id)
        {
            return _entities.ToList().Find(item => item.id == id);
        }
    }
}
    
