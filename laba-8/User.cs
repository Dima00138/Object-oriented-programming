using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Создать класс Пользователь с событиями upgrade и work. В main
создать некоторое количество объектов (ПО). Подпишите объекты
на события произвольным образом. Реакция на события может
быть следующая: обновление версии, вывод сообщений и т.п.
Проверить результаты изменения объектов после наступления
событий*/
namespace laba_8
{
    internal class User
    {
        public string rank = "Beginner";
        public int money = 0;

        public delegate void UpgradeH(string message);
        public delegate void WorkH(string message);
        public event UpgradeH? Upgrade;
        public event WorkH? Work;

        public void RankUp(bool cond)
        {
            if (cond)
            {
                rank = (rank == "Beginner") ? "Advanced" : "Master";
                Upgrade?.Invoke("Upgrade");
            }
            else
            {
                rank = (rank == "Master") ? "Advanced" : "Beginner";
                Upgrade?.Invoke("Degrade");
            } 
        }
        public void Working()
        {
            if (rank == "Beginner")
            {
                money += 10;
                Work?.Invoke("Заработано 10 монет");
            }
            else if (rank == "Advanced")
            {
                money += 100;
                Work?.Invoke("Заработано 100 монет");
            }
            else
            {
                money += 1000;
                Work?.Invoke("Заработано 1000 монет");
            }
        }

    }
}
