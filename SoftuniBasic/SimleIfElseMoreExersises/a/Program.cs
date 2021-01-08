import java.util.Scanner;

public class Harvest
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);

        int vineYard = Integer.parseInt(scanner.nextLine());
        double grapes = Double.parseDouble(scanner.nextLine());
        int liters = Integer.parseInt(scanner.nextLine());
        int workers = Integer.parseInt(scanner.nextLine());

        double harvest = (vineYard * 0.4) * grapes;
        double wine = harvest / 2.5;
        double litersLeft = Math.abs(wine - liters);
        double litersPerPerson = litersLeft / workers;

        if (wine < liters)
        {
            System.out.printf("It will be a tough winter! More %.0f liters wine needed.", Math.floor(litersLeft));
        }
        else if (wine >= liters)
        {
            System.out.printf("Good harvest this year! Total wine: %.0f liters.", Math.floor(wine));
            System.out.println();
            System.out.printf("%s liters left -> %s liters per person.", (int)Math.ceil(litersLeft), (int)Math.ceil(litersPerPerson));
        }
    }
}