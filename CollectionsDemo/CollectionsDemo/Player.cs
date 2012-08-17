using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace CollectionsDemo
{
    class Player
    {
        string pname;

        public string PlayerName
        {
            get { return pname; }
            set { pname = value; }
        }
        int runs;

        public int Runs
        {
            get { return runs; }
            set { runs = value; }
        }

        public Player(string nm, int r)
        {
            pname = nm;
            runs = r;
        }
    }
    class Team : IEnumerable
    {
        Player[] players=null;
        static int count;
        public Team()
        {
             players = new Player[3];
        }
        public void Add(Player p)
        {
            int i = count;
            if (i < 3)
            {
                players[i] = p;
                count++;

            }
        }

        public IEnumerator GetEnumerator()
        {
           return players.GetEnumerator();
        }
    }

}
