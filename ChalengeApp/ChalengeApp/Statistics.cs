namespace ChalengeApp
{
    public class Statistics
    {
        public float Min { get; set; }

        public float Max { get; set; }

        //.....................................// Opis Lini Poniżej - Zobacz nr 1
        public float Sum { get; private set; } // Info o Lini KODU w Dzien 18 Lek 3 2:00 min
                                               // Suma wartości które będą się dodawać
        public int Count { get; private set; } // Info o Lini KODU w Dzien 18 Lek 3 2:10 min
                                               // informacja ile ocen już przyszło
                                               // ZMIENIONY KOD PROGRAMU 3:00 min
                                               // -- public float Average { get; private set; } // Stary Kod Zamieniony

        public float Average         // Nowy Zamieniony Wpis Kodu obliczający średnią
        {
            get
            {
                return this.Sum / this.Count;
            }
        }

        //public char AverageLetter { get; private set; }

        // Nowy Wpis w Kodzie Programu  ---------------------

        public char AverageLetter
        {
            get
            {
                //// NOWE WPISY W KODZIE PROG Zmieniony Kod Prog Info 5:15 min
                switch (this.Average)
                {
                    case var average when average >= 80:
                        // statistics.AverageLetter = 'A'; -- Skasowane 
                        // break;  -- Skasowane Zmieniony Kod Programu  5:15 min
                        return 'A';

                    case var average when average >= 60:
                        return 'B';

                    case var average when average >= 40:
                        return 'C';

                    case var average when average >= 20:
                        return 'D';

                    default:
                        return 'E';
                }
               // return statistics;  -- Do Skasowania
            }
        }



        public Statistics()  // - Konstruktor // Info o Lini KODU w Dzien 18 Lek 3 3:00 min
        {
           // -Wszystkie wartości liczb do obliczeń będą przekazane do Konstruktora 3:00 min

                           // Opis Lini Poniżej - Zobacz nr 2
                           // Info o Liniach KODU w Dzien 18 Lek 4  0:40 min
           this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }

        //.....................................// Opis Lini Poniżej - Zobacz nr 3
        // Możliwość Dodawania Ocen  - 2:00 min
        public void AddGrade(float grade)
        {
           // -Wszystkie oceny statystyk dodajemy tutaj -Kod
           this.Count++;  // Wyjaśnić że przy pierwszym wywołaniu z zera robi się jeden 1:40 min Statistics.cs
            this.Sum += grade;  // Dodajemy wartość która przyszła do grade  2:00 min Statistics.cs
            this.Min = Math.Min(grade, this.Min);
            this.Max = Math.Max(grade, this.Max);
        }
    }
}