/*
 * Bunny and the fox simulator
 * 
 * the bunny always move in a straight line in one direction
 * the fox always move in a straight line towards the bunny
 * 
 * displays how they both move and when the bunny is caught
 */

class Program {
    public static void Main(string[] args) {
        Creature bunny = new Creature(0, 40, 10);
        Creature fox = new Creature(0, 0, 5);
        double distanceNormal;
        double distance = 0;
        
        while (distance < fox.Speed) {
            //move bunny
            bunny.X += bunny.Speed;
            
            //calculate distance between bunny and fox
            distance = Math.Sqrt(Math.Pow(bunny.X - fox.X, 2) + Math.Pow(bunny.Y - fox.Y, 2));
            //calculate how much the foxes speed need to be adjusted to
            distanceNormal = distance / fox.Speed;

            //move fox
            fox.X += (bunny.X - fox.X) * distanceNormal;
            fox.Y += (bunny.Y - fox.Y) * distanceNormal;
            
            //Print info
            Console.Write("bunny: ");
            bunny.PrintCoordinates();
            Console.Write("fox: ");
            fox.PrintCoordinates();
            Console.WriteLine("******************");
        }
        Console.WriteLine("the fox caught the bunny");
    }

    class Creature {
        public double Y { get; set; }
        public double X { get; set; }
        public int Speed { get; set; }

        public Creature(int x, int y, int speed) {
            X = x;
            Y = y;
            Speed = speed;
        }

        public void PrintCoordinates() {
            Console.WriteLine($"x: {X} y: {Y}");
        }

    }
}