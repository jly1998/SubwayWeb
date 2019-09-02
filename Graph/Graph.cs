using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Graph
{
    class Stop
    {
        public String name;
        public int Trans;
        public LinkedList<int> Lines;
    }
    class Node
    {
        public Stop s;
        public LinkedList<string> head;
    }

    class Line
    {
        public int Num;
        public LinkedList<string> head;


    }

    class Lines
    {
        public Line[] L;
        public int Numbers;

        public Lines()
        {
            Numbers = 0;
            L = new Line[64];
        }

        public void AddLine(int No, int num, string[] names)
        {
            this.L[Numbers] = new Line();
            L[Numbers].Num = No;
            L[Numbers].head = new LinkedList<string>();

            int i;
            for (i = 0; i < num; i++)
            {
                L[Numbers].head.AddLast(names[i]);

            }
            Numbers++;
        }

        public string printLines()
        {
            string result = "";
            int i;
            for (i = 0; i < Numbers; i++)
            {
                LinkedListNode<string> current = L[i].head.First;

                result = result + L[i].Num;

                result = result + "号线 : ";

                while (current != null)
                {
                    result = result + current.Value.ToString();
                    result = result + " - ";
                    current = current.Next;
                }
                result = result + "\r\n";
            }

            return result;
        }
    }


    class ALGraph
    {
        public Node[] algraph;
        public int Vertices;

        public ALGraph()
        {
            this.Vertices = 0;
            this.algraph = new Node[1024];
        }

        public void AddVex(string Vex)
        {
            int i;
            bool exist = false;

            for (i = 0; i < Vertices; i++)
            {
                if (this.algraph[i].s.name == Vex)
                {
                    exist = true;
                    break;
                }
            }

            if (exist)
                return;

            this.algraph[Vertices] = new Node();
            this.algraph[Vertices].head = new LinkedList<string>();


            this.algraph[Vertices].head.AddLast(Vex);
            this.algraph[Vertices].s = new Stop();
            this.algraph[Vertices].s.name = Vex;
            this.algraph[Vertices].s.Lines = new LinkedList<int>();
            this.algraph[Vertices].s.Trans = 0;

            Vertices = Vertices + 1;

        }

        public void AddArc(string A, string B, int l)
        {
            bool Aexist = false, Bexist = false;
            int i, j;

            for (i = 0; i < Vertices; i++)
            {
                if (this.algraph[i].s.name == A)
                {
                    Aexist = true;
                    algraph[i].head.AddLast(B);
                    LinkedListNode<int> current = this.algraph[i].s.Lines.First;

                    for (j = 0; j < this.algraph[i].s.Trans; j++, current = current.Next)
                    {
                        if (current.Value == l)
                        {
                            break;
                        }
                    }
                    if (j == this.algraph[i].s.Trans)
                    {
                        this.algraph[i].s.Trans++;
                        this.algraph[i].s.Lines.AddLast(l);
                    }
                    System.Diagnostics.Debug.Write(algraph[i].s.Trans);

                }
                if (this.algraph[i].s.name == B)
                {
                    Bexist = true;
                    algraph[i].head.AddLast(A);
                    LinkedListNode<int> current = this.algraph[i].s.Lines.First;

                    for (j = 0; j < this.algraph[i].s.Trans; j++, current = current.Next)
                    {
                        if (current.Value == l)
                        {
                            break;
                        }
                    }
                    if (j == this.algraph[i].s.Trans)
                    {
                        this.algraph[i].s.Trans++;
                        this.algraph[i].s.Lines.AddLast(l);
                    }
                    System.Diagnostics.Debug.Write(algraph[i].s.Trans);
                }
            }

            if (!Aexist && !Bexist)
            {
                AddVex(A);
                AddVex(B);
                algraph[Vertices - 2].head.AddLast(B);
                algraph[Vertices - 2].s.Lines.AddLast(l);
                algraph[Vertices - 2].s.Trans++;
                algraph[Vertices - 1].head.AddLast(A);
                algraph[Vertices - 1].s.Lines.AddLast(l);
                algraph[Vertices - 1].s.Trans++;


            }
            else
            {
                if (!Aexist && Bexist)
                {
                    AddVex(A);
                    algraph[Vertices - 1].head.AddLast(B);
                    algraph[Vertices - 1].s.Lines.AddLast(l);
                    algraph[Vertices - 1].s.Trans++;

                }

                if (Aexist && !Bexist)
                {
                    AddVex(B);
                    algraph[Vertices - 1].head.AddLast(A);
                    algraph[Vertices - 1].s.Lines.AddLast(l);
                    algraph[Vertices - 1].s.Trans++;

                }
            }

        }


        public string Print()
        {
            string result = "";
            string arrow = " --> ";
            string enter = "\r\n";
            string space = " ";
            for (int i = 0; i < Vertices; i++)
            {
                LinkedListNode<string> current = algraph[i].head.First;

                result = result + algraph[i].s.name;
                System.Diagnostics.Debug.Write(i);
                result = result + arrow;
                System.Diagnostics.Debug.Write(" --> ");
                current = current.Next;
                while (current != null)
                {
                    result = result + current.Value.ToString();
                    System.Diagnostics.Debug.Write(current.Value);
                    result = result + space;
                    System.Diagnostics.Debug.Write(" ");
                    current = current.Next;
                }
                result = result + enter;
                System.Diagnostics.Debug.Write('\n');
            }
            return result;
        }

        public string GetTrans()
        {
            string result = "";

            for (int i = 0; i < Vertices; i++)
            {
                if (algraph[i].s.Trans > 1)
                {
                    result += algraph[i].s.name;

                    result += " : ";

                    LinkedListNode<int> current = algraph[i].s.Lines.First;
                    while (current != null)
                    {
                        result += current.Value;
                        result += " ";
                        current = current.Next;
                    }
                    result = result + "\r\n";
                }
            }
            return result;
        }


       
        //定位顶点
        public int LocateVex(string StopName)
        {

            int i;
            for (i = 0; i < Vertices; i++)
            {
                if (algraph[i].s.name == StopName)
                    return i;
            }
            return -1;
        }//LocateVex

        //最短路径
        public string shortestPath(string begin, string end)
        {
            int b, e;
            b = LocateVex(begin);
            e = LocateVex(end);

            int i, j, min, pos, count, f;
           
            int[] dis = new int[Vertices];

            bool[] true_dis = new bool[Vertices];

            for (i = 0; i < Vertices; i++)
            {
                dis[i] = 1024;
                true_dis[i] = false;
            }
           
            dis[b] = 0;
            true_dis[b] = true;

            List<string>[] Route = new List<string>[Vertices];
            for (count = 0; count < Vertices; count++)
            {
                Route[count] = new List<string>();
                Route[count].Add(algraph[count].s.name);
            }

            i = b;
            for (count = 0; count < Vertices; count++)
            {
                min = 1024;
                pos = 0;
                LinkedListNode<string> p = algraph[i].head.First;
                p = p.Next;

                while (p != null) 
                {
                    if (true_dis[LocateVex(p.Value)] == true)
                    {
                        p = p.Next;
                        continue;
                    }
                    if (1 + dis[i] < dis[LocateVex(p.Value)])
                    {
                        dis[LocateVex(p.Value)] = 1 + dis[i];
                        Route[LocateVex(p.Value)].Clear();
                        foreach (string T in Route[i])
                        {
                            Route[LocateVex(p.Value)].Add(T);
                        }
                        Route[LocateVex(p.Value)].Add(algraph[LocateVex(p.Value)].s.name);
                        System.Diagnostics.Debug.Write(p.Value);
                   //     System.Diagnostics.Debug.Write(Route[LocateVex(p.Value)]);
                    }
                    p = p.Next; 
                }
                for (j = 0; j < Vertices; j++)
                {
                    if (true_dis[j] == false && dis[j] < min)
                    {
                        pos = j;
                        min = dis[j];
                    }
                }
                if (pos == e)
                {
                    break;
                }
                i = pos;
                true_dis[pos] = true;
            }

            return string.Join(" ", Route[e].ToArray());

        }//shortestPath

    }
}