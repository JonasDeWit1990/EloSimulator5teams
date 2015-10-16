using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EloSimulator5teams
{
    public partial class Form1 : Form
    {
        int[,] Combinations = new int[252, 5] {{0,1,2,3,4},{0,1,2,3,5},{0,1,2,3,6},{0,1,2,3,7},{0,1,2,3,8},{0,1,2,3,9},{0,1,2,4,5},{0,1,2,4,6},{0,1,2,4,7},{0,1,2,4,8},{0,1,2,4,9},
                        {0,1,2,5,6},{0,1,2,5,7},{0,1,2,5,8},{0,1,2,5,9},{0,1,2,6,7},{0,1,2,6,8},{0,1,2,6,9},{0,1,2,7,8},{0,1,2,7,9},{0,1,2,8,9},{0,1,3,4,5},
                        {0,1,3,4,6},{0,1,3,4,7},{0,1,3,4,8},{0,1,3,4,9},{0,1,3,5,6},{0,1,3,5,7},{0,1,3,5,8},{0,1,3,5,9},{0,1,3,6,7},{0,1,3,6,8},{0,1,3,6,9},
                        {0,1,3,7,8},{0,1,3,7,9},{0,1,3,8,9},{0,1,4,5,6},{0,1,4,5,7},{0,1,4,5,8},{0,1,4,5,9},{0,1,4,6,7},{0,1,4,6,8},{0,1,4,6,9},{0,1,4,7,8},
                        {0,1,4,7,9},{0,1,4,8,9},{0,1,5,6,7},{0,1,5,6,8},{0,1,5,6,9},{0,1,5,7,8},{0,1,5,7,9},{0,1,5,8,9},{0,1,6,7,8},{0,1,6,7,9},{0,1,6,8,9},
                        {0,1,7,8,9},{0,2,3,4,5},{0,2,3,4,6},{0,2,3,4,7},{0,2,3,4,8},{0,2,3,4,9},{0,2,3,5,6},{0,2,3,5,7},{0,2,3,5,8},{0,2,3,5,9},{0,2,3,6,7},
                        {0,2,3,6,8},{0,2,3,6,9},{0,2,3,7,8},{0,2,3,7,9},{0,2,3,8,9},{0,2,4,5,6},{0,2,4,5,7},{0,2,4,5,8},{0,2,4,5,9},{0,2,4,6,7},{0,2,4,6,8},
                        {0,2,4,6,9},{0,2,4,7,8},{0,2,4,7,9},{0,2,4,8,9},{0,2,5,6,7},{0,2,5,6,8},{0,2,5,6,9},{0,2,5,7,8},{0,2,5,7,9},{0,2,5,8,9},{0,2,6,7,8},
                        {0,2,6,7,9},{0,2,6,8,9},{0,2,7,8,9},{0,3,4,5,6},{0,3,4,5,7},{0,3,4,5,8},{0,3,4,5,9},{0,3,4,6,7},{0,3,4,6,8},{0,3,4,6,9},{0,3,4,7,8},
                        {0,3,4,7,9},{0,3,4,8,9},{0,3,5,6,7},{0,3,5,6,8},{0,3,5,6,9},{0,3,5,7,8},{0,3,5,7,9},{0,3,5,8,9},{0,3,6,7,8},{0,3,6,7,9},{0,3,6,8,9},
                        {0,3,7,8,9},{0,4,5,6,7},{0,4,5,6,8},{0,4,5,6,9},{0,4,5,7,8},{0,4,5,7,9},{0,4,5,8,9},{0,4,6,7,8},{0,4,6,7,9},{0,4,6,8,9},{0,4,7,8,9},
                        {0,5,6,7,8},{0,5,6,7,9},{0,5,6,8,9},{0,5,7,8,9},{0,6,7,8,9},{1,2,3,4,5},{1,2,3,4,6},{1,2,3,4,7},{1,2,3,4,8},{1,2,3,4,9},{1,2,3,5,6},
                        {1,2,3,5,7},{1,2,3,5,8},{1,2,3,5,9},{1,2,3,6,7},{1,2,3,6,8},{1,2,3,6,9},{1,2,3,7,8},{1,2,3,7,9},{1,2,3,8,9},{1,2,4,5,6},{1,2,4,5,7},
                        {1,2,4,5,8},{1,2,4,5,9},{1,2,4,6,7},{1,2,4,6,8},{1,2,4,6,9},{1,2,4,7,8},{1,2,4,7,9},{1,2,4,8,9},{1,2,5,6,7},{1,2,5,6,8},{1,2,5,6,9},
                        {1,2,5,7,8},{1,2,5,7,9},{1,2,5,8,9},{1,2,6,7,8},{1,2,6,7,9},{1,2,6,8,9},{1,2,7,8,9},{1,3,4,5,6},{1,3,4,5,7},{1,3,4,5,8},{1,3,4,5,9},
                        {1,3,4,6,7},{1,3,4,6,8},{1,3,4,6,9},{1,3,4,7,8},{1,3,4,7,9},{1,3,4,8,9},{1,3,5,6,7},{1,3,5,6,8},{1,3,5,6,9},{1,3,5,7,8},{1,3,5,7,9},
                        {1,3,5,8,9},{1,3,6,7,8},{1,3,6,7,9},{1,3,6,8,9},{1,3,7,8,9},{1,4,5,6,7},{1,4,5,6,8},{1,4,5,6,9},{1,4,5,7,8},{1,4,5,7,9},{1,4,5,8,9},
                        {1,4,6,7,8},{1,4,6,7,9},{1,4,6,8,9},{1,4,7,8,9},{1,5,6,7,8},{1,5,6,7,9},{1,5,6,8,9},{1,5,7,8,9},{1,6,7,8,9},{2,3,4,5,6},{2,3,4,5,7},
                        {2,3,4,5,8},{2,3,4,5,9},{2,3,4,6,7},{2,3,4,6,8},{2,3,4,6,9},{2,3,4,7,8},{2,3,4,7,9},{2,3,4,8,9},{2,3,5,6,7},{2,3,5,6,8},{2,3,5,6,9},
                        {2,3,5,7,8},{2,3,5,7,9},{2,3,5,8,9},{2,3,6,7,8},{2,3,6,7,9},{2,3,6,8,9},{2,3,7,8,9},{2,4,5,6,7},{2,4,5,6,8},{2,4,5,6,9},{2,4,5,7,8},
                        {2,4,5,7,9},{2,4,5,8,9},{2,4,6,7,8},{2,4,6,7,9},{2,4,6,8,9},{2,4,7,8,9},{2,5,6,7,8},{2,5,6,7,9},{2,5,6,8,9},{2,5,7,8,9},{2,6,7,8,9},
                        {3,4,5,6,7},{3,4,5,6,8},{3,4,5,6,9},{3,4,5,7,8},{3,4,5,7,9},{3,4,5,8,9},{3,4,6,7,8},{3,4,6,7,9},{3,4,6,8,9},{3,4,7,8,9},{3,5,6,7,8},
                        {3,5,6,7,9},{3,5,6,8,9},{3,5,7,8,9},{3,6,7,8,9},{4,5,6,7,8},{4,5,6,7,9},{4,5,6,8,9},{4,5,7,8,9},{4,6,7,8,9},{5,6,7,8,9}};



        int GamesPlayed = 0;
        bool AddPlayerRunning = false, Updategui = false;
        Random RandQueueNumber = new Random(Guid.NewGuid().GetHashCode());
        Random RandQueueTime = new Random(Guid.NewGuid().GetHashCode());
        int StarElo = 1200;
        int EloVar = 800;
        int MaxPlayers = 1000;
        List<Player> QueuePlayers = new List<Player>();
        List<Player> PlayerBase = new List<Player>();

        public void AddPlayerAlways()
        {
            while (AddPlayerRunning == true)
            {
                AddPlayer();
                Thread.Sleep(2);
            }
        }

        public void AddPlayer()
        {
            if(QueuePlayers.Count < MaxPlayers)
            {
                bool Unique = true;
                int PotentialID;

                do
                {
                    Unique = true;
                    PotentialID = RandQueueNumber.Next(1, MaxPlayers + 1);

                    foreach (Player player in QueuePlayers)
                    {
                        if (player.GetID() == PotentialID)
                            Unique = false;
                    }

                } while (Unique == false);

                QueuePlayers.Add(PlayerBase[PotentialID - 1]);

                label1.Invoke((MethodInvoker)(() => label1.Text = "Players in queue: " + QueuePlayers.Count));
                //label1.Text = "Players in Queue: " + QueuePlayers.Count;
                //label1.Refresh();
                List<Player> group = new List<Player>();
                List<Player> sortedgroup = new List<Player>();
                CreateGroup(QueuePlayers, ref group, 0);
                if (group.Count == 10)
                {
                    sortedgroup = CreateFairGrouping(group);
                    MatchResults(sortedgroup);
                    label2.Invoke((MethodInvoker)(() => label2.Text = "Games Played: " + GamesPlayed));
                }
            }
            else
            {
                List<Player> group = new List<Player>();
                List<Player> sortedgroup = new List<Player>();
                int indexing = 0;
                do
                {
                    indexing++;
                    CreateGroup(QueuePlayers, ref group, indexing);
                } while (group.Count != 10);

                    sortedgroup = CreateFairGrouping(group);
                    MatchResults(sortedgroup);
                    label2.Invoke((MethodInvoker)(() => label2.Text = "Games Played: " + GamesPlayed));
                
            }

                //updateGUI();
        }

        public void histResult(List<int> Histogram, int Elo)
        {
            for (int i = 0; i < 16; i++)
            {
                if ((Elo >= ((i + 4) * 100) && Elo < ((i + 5) * 100)))
                    Histogram[i]++;
            }
        }

        public void DrawHist(List<int> TrueHistogram, List<int> CurrentHistogram)
        {
            chart1.Invoke((MethodInvoker)(() => chart1.Series[0].Points.Clear()));

            chart1.Invoke((MethodInvoker)(() => chart1.Series[1].Points.Clear()));

            for (int i = 0; i < 16; i++)
            {
                chart1.Invoke((MethodInvoker)(() => chart1.Series[0].Points.AddXY((i + 4) * 100, TrueHistogram[i] * 100.0 / MaxPlayers)));
                chart1.Invoke((MethodInvoker)(() => chart1.Series[1].Points.AddXY((i + 4) * 100, CurrentHistogram[i] * 100.0 / MaxPlayers)));
            }
        }

        public List<Player> CreateFairGrouping(List<Player> Group)
        {
            List<Player> ordering = new List<Player>();
            List<Player> teamA = new List<Player>();
            List<Player> teamB = new List<Player>();
            ordering.Capacity = 10;
            int EloTeamA = 0, EloTeamB = 0;
            int minimum = 100000;

            for (int row = 0; row < 252; row++)
            {
                EloTeamA = 0;
                EloTeamB = 0;
                for (int index = 0; index < 10; index++)
                {
                    if (index == Combinations[row, 0] || index == Combinations[row, 1] || index == Combinations[row, 2] || index == Combinations[row, 3] ||
                        index == Combinations[row, 4])
                    {
                        EloTeamA += Group[index].CurrentElo;
                        teamA.Add(Group[index]);
                    }
                    else
                    {
                        EloTeamB += Group[index].CurrentElo;
                        teamB.Add(Group[index]);
                    }
                }

                if (minimum > Math.Abs((EloTeamA / 5.0) - (EloTeamB / 5.0)))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        ordering.Add(teamA[i]);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        ordering.Add(teamB[i]);
                    }
                }
            }
            return ordering;
        }

        public void MatchResults(List<Player> Group)
        {
            GamesPlayed++;
            List<Player> teamA = new List<Player>();
            List<Player> teamB = new List<Player>();
            int TrueEloTeamA = 0, TrueEloTeamB = 0,CurrentEloA = 0, CurrentEloB = 0, TotalElo;
            int pointgains;

            for (int i = 0; i < 5; i++)
            {
                TrueEloTeamA += Group[i].GetTrueElo();
                CurrentEloA += Group[i].CurrentElo;
                TrueEloTeamB += Group[i+5].GetTrueElo();
                CurrentEloB += Group[i+5].CurrentElo;
            }

            TrueEloTeamA /= 5;
            TrueEloTeamB /= 5;
            TotalElo = TrueEloTeamA + TrueEloTeamB;
            pointgains = 20;

            Random RandomWin = new Random(Guid.NewGuid().GetHashCode());
            int WhoWon = RandomWin.Next(0, TotalElo);

            int playerindex;
            if (WhoWon < TrueEloTeamA)
            {// team A won
                for (int i = 0; i < 5; i++)
                {
                    playerindex = PlayerBase.IndexOf(Group[i]);
                    PlayerBase[playerindex].CurrentElo += pointgains;
                    PlayerBase[playerindex].GamesPlayed++;

                    playerindex = PlayerBase.IndexOf(Group[i + 5]);
                    PlayerBase[playerindex].CurrentElo -= pointgains;
                    PlayerBase[playerindex].GamesPlayed++;

                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    playerindex = PlayerBase.IndexOf(Group[i]);
                    PlayerBase[playerindex].CurrentElo -= pointgains;

                    playerindex = PlayerBase.IndexOf(Group[i + 5]);
                    PlayerBase[playerindex].CurrentElo += pointgains;

                }
            }
        }

        public void CreateGroup(List<Player> QueueList, ref List<Player> Group, int QueueIndex)
        {
            int RemainingPlayersInQueue = QueueList.Count;
            Random RandPlayernumber = new Random(Guid.NewGuid().GetHashCode());
            int CheckPlayer = 0;
            List<int> GroupplayersID = new List<int>();
            List<int> CheckedPlayers = new List<int>();
            bool Unique = true;
            Group = new List<Player>(); //0-4 = team 1, 5-9 = team 2
            //Group.Capacity = 10;

            //check if enough players are in the Queue
            if (RemainingPlayersInQueue < 10)
            {
                return;
            }

            //take the first player in Queue (oldest in the queue)
            Group.Add(QueueList[QueueIndex]);
            GroupplayersID.Add(0);

            //add players within elo range into the group
            do
            {
                // get a player not checked yet
                do
                {
                    Unique = true;
                    CheckPlayer = RandPlayernumber.Next(0, QueueList.Count);
                    foreach (int playerID in CheckedPlayers)
                    {
                        if (playerID == CheckPlayer)
                        {
                            Unique = false;
                            break;
                        }
                    }
                } while (Unique == false);
                CheckedPlayers.Add(CheckPlayer);

                //Check elo-range (arbitrary 200)
                if (Group[0].CurrentElo > (QueueList[CheckPlayer].CurrentElo - 200) && Group[0].CurrentElo < (QueueList[CheckPlayer].CurrentElo + 200))
                {
                    Group.Add(QueueList[CheckPlayer]);
                    GroupplayersID.Add(CheckPlayer);
                }
                else
                {
                    ;//MessageBox.Show("breakpoint for sake");
                }

            } while (Group.Count < 10 && CheckedPlayers.Count < RemainingPlayersInQueue);

            if (Group.Count == 10)
            {
                GroupplayersID.Sort((a, b) => -1 * a.CompareTo(b));

                for (int i = 0; i < 10; i++)
                    QueueList.RemoveAt(GroupplayersID[i]);
            }
            return;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void updateGUI()
        {
            List<int> TrueEloBars = new List<int>();
            List<int> CurrentEloBars = new List<int>();
            do
            {
                for (int i = 0; i < 16; i++)
                {
                    TrueEloBars.Add(0);
                    CurrentEloBars.Add(0);
                }

                label1.Invoke((MethodInvoker)(() => label1.Text = "Players in queue: " + QueuePlayers.Count));

                dataGridView1.Invoke((MethodInvoker)(() => dataGridView1.Rows.Clear()));
                for (int i = 0; i < MaxPlayers; i++)
                {
                    string[] Row = { PlayerBase[i].GetID().ToString(), PlayerBase[i].GetTrueElo().ToString(), PlayerBase[i].CurrentElo.ToString(), PlayerBase[i].GetGames().ToString() };
                    dataGridView1.Invoke((MethodInvoker)(() => dataGridView1.Rows.Add(Row)));
                    histResult(TrueEloBars, PlayerBase[i].GetTrueElo());
                    histResult(CurrentEloBars, PlayerBase[i].CurrentElo);
                }

                DrawHist(TrueEloBars, CurrentEloBars);
                Thread.Sleep(1000);
            } while (Updategui == true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            Player AddPlayer;
            
            

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "True Elo";
            dataGridView1.Columns[2].Name = "Current Elo";
            dataGridView1.Columns[3].Name = "Games Played";

            for (int i = 0; i < MaxPlayers; i++)
            {
                AddPlayer = new Player(i + 1, StarElo, EloVar);
                PlayerBase.Add(AddPlayer);
            }

            updateGUI();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // creating the child thread
            ThreadStart childref = new ThreadStart(AddPlayerAlways);

            Thread childThread = new Thread(childref);

            if (AddPlayerRunning == true)
            {
                AddPlayerRunning = false;
            }
            else
            {
                AddPlayerRunning = true;
                childThread.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            ThreadStart childref = new ThreadStart(updateGUI);
            Thread childThread = new Thread(childref);
            if (Updategui == true)
                Updategui = false;
            else
            {
                Updategui = true;
                childThread.Start();
            }
             */
            updateGUI();
        }
    }

    public class Player
    {
        private int ID;
        private int TrueElo;
        public int CurrentElo;
        public int GamesPlayed;

        public Player(int iD, int StarterElo, int EloVariation)
        {
            ID = iD;
            Random RandNumber = new Random(Guid.NewGuid().GetHashCode());
            double u1 = RandNumber.NextDouble(); //these are uniform(0,1) random doubles
            double u2 = RandNumber.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                         Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            double randNormal =
                         StarterElo + ((EloVariation / 3) * randStdNormal);

            CurrentElo = StarterElo;
            TrueElo = Convert.ToInt32(randNormal);
            //TrueElo = RandNumber.Next(StarterElo - EloVariation, StarterElo + EloVariation);
            GamesPlayed = 0;
        }

        public int GetTrueElo()
        {
            return TrueElo;
        }

        public int GetID()
        {
            return ID;
        }

        public int GetGames()
        {
            return GamesPlayed;
        }
    }
}
