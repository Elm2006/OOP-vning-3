﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Namn
{
    private string förnamn;
    private string efternamn;

    public string Förnamn
    {
        get { return förnamn; }

        set { förnamn = value; }
    }
    public string Efternamn
    {
        get { return efternamn; }

        set { efternamn = value; }
    }
    public void FullNamn()
    {
        string helnamn = förnamn + " " + efternamn;
        Console.WriteLine(helnamn);
    }
    public bool Ålder()
    {
        Console.WriteLine("Vilket år är du född?");
        int år = int.Parse(Console.ReadLine());
        Console.WriteLine("Vilken månad");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Vilken dag?");
        int d = int.Parse(Console.ReadLine());
        DateTime datetime = DateTime.Now;
        int y = datetime.Year;
        int mo =datetime.Month;
        int da=datetime.Day;
        if (år+18<y) 
        {
            return(true);
        }
        else if (år+18 == y)
        {
            if (mo>m) 
            { 
                return(true) ;
            }
            else if(mo==m)
            {
                if(d<=da)
                {
                    return (true) ;
                }
                else
                {
                    return(false) ;
                }
            }
            else 
            { 
                return(false) ; 
            }
        }
        else
        {
            return (false);
        }
    }
}
