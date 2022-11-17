Console.WriteLine("Vols la pizza vegetariana? ");
string input = Console.ReadLine();
if (input == "si")
{
    Console.WriteLine("els ingredients vegetarians són  1. pebrot i 2. tofu.");
    Console.WriteLine("Quin ingredient vols? ");
    input = Console.ReadLine();
    int ingredient = int.Parse(input);
    if (ingredient == 1)
    {
        Console.WriteLine("La pizza és vegetariana i du mozzarella, tomàquet i pebrot");
    }
    else
    {
        Console.WriteLine("La pizza és vegetariana i du mozzarella, tomàquet i tofu");
    }
}
else
{
    Console.WriteLine("els ingredients no vegetarians són 1. Peperoni, 2. Pernil i 3. Salmó.");
    Console.WriteLine("Quin ingredient vols? ");
    input = Console.ReadLine();
    int ingredient = int.Parse(input);
    if (ingredient == 1)
    {
        Console.WriteLine("La pizza no és vegetariana i du mozzarella, tomàquet i peperoni");
    }
    else if (ingredient == 2)
    {
        Console.WriteLine("La pizza no és vegetariana i du mozzarella, tomàquet i pernil");
    }
    else
    {
        Console.WriteLine("La pizza no és vegetariana i du mozzarella, tomàquet i salmó");
    }

}