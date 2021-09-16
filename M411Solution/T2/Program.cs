using System;

namespace T2
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Liste erstellen
                Figures<ActionFigure> figures = new Figures<ActionFigure>();

                // Action Figur erstellen
                ActionFigure f = new ActionFigure(ActionFigure.DirectionTyp.Down);

                // Action Figur hinzufügen
                figures.Add(f);
                figures.Add(new ActionFigure(ActionFigure.DirectionTyp.Up));
                figures.Add(new ActionFigure(ActionFigure.DirectionTyp.Left));
                figures.Add(new ActionFigure(ActionFigure.DirectionTyp.Rigth));

                // Figur über Index anzeigen und Index über Figur anzeigen lassen
                Console.WriteLine($"Index(Down): {figures[0].Direction}");
                Console.WriteLine($"Figur(0): {figures.IndexOf(f)}");

                Console.WriteLine($"4 Figuren in der Liste(Count): {figures.Count}");

                Console.ReadLine();

                // Liste Leeren
                figures.Clear();

                Console.WriteLine($"Leere Liste(Count): {figures.Count}");

                Console.ReadKey();

                // Figur Hinzufügen
                figures.Add(f);

                // Infos
                Console.WriteLine($"Figur Direktion(Down): {figures[0].Direction}, Figur Index(0): {figures.IndexOf(f)} ");

                Console.ReadKey();

                // Figur Löschen
                figures.Remove(f);
              
                // Mehr adden
                figures.Add(new ActionFigure(ActionFigure.DirectionTyp.Up));
                figures.Add(new ActionFigure(ActionFigure.DirectionTyp.Left));
                figures.Add(f);
                figures.Add(new ActionFigure(ActionFigure.DirectionTyp.Rigth));

                figures[2].IsActive = false;

                // Infos
                Console.WriteLine($"Figur IsActive(false): {figures[0].IsActive}, Figur Index(2): {figures.IndexOf(f)} ");

                // Figur löschen
                figures.Remove(figures[3]);

                // Figur die gelöscht wurde Anzeigen
                Console.WriteLine($"Figur Direktion die gelöscht wurde: {figures[3].Direction}");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }
    }
}
