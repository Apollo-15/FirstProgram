using System;
namespace FirstProgram
{
    class FirstProgram
    {
        public static void Main(string[] args)
        {
            // PPRG

            // Poziom łatwy

            // DisplayCard();
            // DisplayGreeting();
            // AgeCalculator();

            // Poziom średni

            // TravelCalculator();
            // TravelPurseCalculator();
            // PotionProportions();
            // AccommodationCostCalculator();

            // Poziom trudny

            // TimeConversion();
            // LootDivision();
            // HeroDamageCalculation();
            // TravelJournal();

            // Zadanie Projectowe

            // HelloAdventure();

            // WARP

            System.Console.WriteLine("Hello, Warsztacie Programisty!");
        }

        public static void DisplayCard()
        {
            System.Console.Write("Imię: ");
            String name = System.Console.ReadLine();

            System.Console.Write("Wiek: ");
            String age = System.Console.ReadLine();

            System.Console.Write("Gra: ");
            String game = System.Console.ReadLine();

            System.Console.WriteLine("+--------------------------+");
            System.Console.WriteLine("|\t Wizytówka \t|");
            System.Console.WriteLine("+--------------------------+");
            System.Console.WriteLine($"| Imię: {name}\t|");
            System.Console.WriteLine($"| Wiek: {age} \t|");
            System.Console.WriteLine($"| Gra: {game} \t|");
            System.Console.WriteLine("+--------------------------+");
        }

        public static void DisplayGreeting()
        {
            System.Console.Write("Jak masz na imię?: ");
            String name = System.Console.ReadLine();
            
            System.Console.Write("Jaki jest Twój ulubiony kolor?: ");
            String color = System.Console.ReadLine();

            System.Console.WriteLine($"Cześć {name}! {color} to świetny kolor na płaszcz poszukiwacza przygód");
        }

        public static void AgeCalculator()
        {
            System.Console.Write("Ile masz lat?: ");
            int age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Ile lat chcesz dodać?: ");
            int yearsToAdd = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine($"Za {yearsToAdd} lat(a) będziesz mieć {age + yearsToAdd} lat.");
        }

        public static void TravelCalculator()
        {
            System.Console.Write("Podaj liczbę kiometrów do celu: ");
            int distance = int.Parse(System.Console.ReadLine());

            System.Console.Write("Pidaj liczbę kilometrów pokonywanych każdego dnia: ");
            int dailyDistance = int.Parse(System.Console.ReadLine());

            double days = (double)distance / dailyDistance;

            System.Console.WriteLine($"Podróż do celu zajmie {days} dni.");
        }

        public static void TravelPurseCalculator()
        {
            System.Console.Write("Podaj liczbę złotych monet: ");
            int goldCoins = int.Parse(System.Console.ReadLine());

            System.Console.Write("Podaj liczbę srebrnych monet: ");
            int silverCoins = int.Parse(System.Console.ReadLine());

            System.Console.Write("Podaj liczbę miedzianych monet: ");
            int copperCoins = int.Parse(System.Console.ReadLine());

            int totalValue = (goldCoins * 100) + (silverCoins * 10) + copperCoins;

            System.Console.WriteLine($"Łączna wartość sakiewki wynosi {totalValue} miedzianych monet.");
        }
    
        public static void PotionProportions()
        {
            System.Console.Write("Podaj liczbę mikstur do przygotowania: ");
            int potions = int.Parse(System.Console.ReadLine());

            int crystalsNeeded = potions * 3;
            int herbsNeeded = potions * 2;

            System.Console.WriteLine($"Do przygotowania {potions} mikstur potrzebujesz: ");
            System.Console.WriteLine($"- {crystalsNeeded} kryształów");
            System.Console.WriteLine($"- {herbsNeeded} ziół");
        }

        public static void AccommodationCostCalculator()
        {
            System.Console.Write("Podaj cenę noclegu: ");
            decimal pricePerNight = decimal.Parse(System.Console.ReadLine());

            System.Console.Write("Podaj liczbę nocy: ");
            int numberOfNights = int.Parse(System.Console.ReadLine());

            decimal totalCost = pricePerNight * numberOfNights;
            System.Console.WriteLine($"Koszt całego pobytu wynosi {totalCost} złotych.");
        }
    
        public static void TimeConversion()
        {
            System.Console.Write("Podaj liczbę sekund: ");
            int totalSeconds = int.Parse(System.Console.ReadLine());

            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            System.Console.WriteLine($"{totalSeconds} sekund to {minutes} minut i {seconds} sekund.");
        }

        public static void LootDivision()
        {
            System.Console.Write("Podaj liczbę złotych monet: ");
            int totalCoins = int.Parse(System.Console.ReadLine());

            System.Console.Write("Podaj liczbę bohaterów: ");
            int numberOfHeroes = int.Parse(System.Console.ReadLine());

            if(numberOfHeroes == 0)
            {
                System.Console.WriteLine("Liczba bohaterów nie może wynosić zero.");
                return;
            }

            int coinsPerHero = totalCoins / numberOfHeroes;
            int remainingCoins = totalCoins % numberOfHeroes;

            System.Console.WriteLine($"Każdy bohater otrzyma {coinsPerHero} pełnych monet.");
            System.Console.WriteLine($"Pozostanie {remainingCoins} monet.");
        }

        public static void HeroDamageCalculation()
        {
            System.Console.Write("Podaj wartość podstawowych obrażeń broni: ");
            int baseDamage = int.Parse(System.Console.ReadLine());

            System.Console.Write("Podaj premię do siły: ");
            int strengthBonus = int.Parse(System.Console.ReadLine());

            int normalAttackDamage = baseDamage + strengthBonus;
            int specialAttackDamage = normalAttackDamage * 2;
            int totalDamage = (normalAttackDamage * 3) + specialAttackDamage;

            System.Console.WriteLine($"Obrażenia zwykłego ataku: {normalAttackDamage}");
            System.Console.WriteLine($"Obrażenia ataku specjalnego: {specialAttackDamage}");
            System.Console.WriteLine($"Łączne obrażenia trzech zwykłych ataków i jednego specjalnego: {totalDamage}");
        }
    
        public static void TravelJournal()
        {
            System.Console.Write("Podaj nazwę bohatera: ");
            String heroName = System.Console.ReadLine();

            System.Console.Write("Podaj nazwę krainy: ");
            String landName = System.Console.ReadLine();

            System.Console.Write("Podaj liczbę dni wyprawy: ");
            int days = int.Parse(System.Console.ReadLine());

            System.Console.Write("Podaj liczbę zdobytych punktów doświadczenia: ");
            int experiencePoints = int.Parse(System.Console.ReadLine());

            System.Console.Write("Podaj ilość zebranego złota: ");
            int goldCollected = int.Parse(System.Console.ReadLine());

            if (days == 0)
            {
                System.Console.WriteLine("Liczba dni nie może wynosić zero.");
                return;
            }

            double averageExperiencePerDay = (double)experiencePoints / days;
            double averageGoldPerDay = (double)goldCollected / days;

            System.Console.WriteLine("\nDziennik wyprawy:");
            System.Console.WriteLine($"Bohater: {heroName}");
            System.Console.WriteLine($"Kraina: {landName}");
            System.Console.WriteLine($"Liczba dni wyprawy: {days}");
            System.Console.WriteLine($"Średnia liczba punktów doświadczenia na dzień: {averageExperiencePerDay}");
            System.Console.WriteLine($"Średnia ilość złota na dzień: {averageGoldPerDay}");
        }
    
        public static void HelloAdventure()
        {
            // Zadanie projektowe — „Hello Adventurer”
            //
            // Wymagania
            // Program powinien:
            // 1. wyświetlić tytuł gry,
            // 2. zapytać użytkownika o imię gracza,
            // 3. zapisać w zmiennych co najmniej cztery statystyki bohatera, np. punkty życia, siłę, złoto i poziom doświadczenia,
            // 4. użyć co najmniej trzech różnych typów danych,
            // 5. wykonać jedno lub dwa proste obliczenia związane z bohaterem,
            // 6. wyświetlić imię, statystyki i wyniki obliczeń jako czytelną kartę postaci,
            // 7. wykorzystać interpolację tekstu przynajmniej w jednym miejscu.

            // Wariant z ikonami
            // ╔════════════════════════════════╗
            // ║       KARTA POSZUKIWACZA       ║
            // ╠════════════════════════════════╣
            // ║  ⚔  Kael                       ║
            // ║  ♥  Życie ............... 90   ║
            // ║  ◆  Siła ................ 14   ║
            // ║  ●  Złoto ............... 27   ║
            // ╠════════════════════════════════╣
            // ║  Atak specjalny: 28            ║
            // ╚════════════════════════════════╝

            System.Console.WriteLine("Witaj w grze \"Hello Adventurer\"");
            System.Console.Write("Podaj imię bohatera: ");
            String heroName = System.Console.ReadLine();

            System.Console.Write("Podaj punkty życia: ");
            int healthPoints  = int.Parse(System.Console.ReadLine());

            System.Console.Write("Podaj siłę: ");
            int strength = int.Parse(System.Console.ReadLine());

            System.Console.Write("Podaj ilość złota: ");
            int gold = int.Parse(System.Console.ReadLine());

            System.Console.Write("podaj poziom doświadczenia: ");
            int experienceLevel = int.Parse(System.Console.ReadLine());

            int specialAttack = strength * 2;

            System.Console.WriteLine("╔════════════════════════════════╗");
            System.Console.WriteLine("║\t KARTA POSZUKIWACZA \t ║");
            System.Console.WriteLine("╠════════════════════════════════╣");
            System.Console.WriteLine($"║  ⚔ {heroName}\t\t\t ║");
            System.Console.WriteLine($"║  ♥ Życie ............... {healthPoints}\t ║");
            System.Console.WriteLine($"║  ◆ Siła ................ {strength}\t ║");
            System.Console.WriteLine($"║  ● Złoto ............... {gold}\t ║");
            System.Console.WriteLine("╠════════════════════════════════╣");
            System.Console.WriteLine($"║  Atak specjalny: {specialAttack}\t\t ║");
            System.Console.WriteLine("╚════════════════════════════════╝");


        }
    }
}
