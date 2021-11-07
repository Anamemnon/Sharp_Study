public class ParkingSystem
{
    public static int Big { get; set; }
    public static int Medium { get; set; }
    public static int Small { get; set; }

    public ParkingSystem(int big, int medium, int small)
    {
        Big = big;
        Medium = medium;
        Small = small;
    }

    public bool AddCar(int carType)
    {
        switch (carType)
        {
            case 1:
                {
                    if (Big > 0)
                    {
                        Big--;
                        return true;
                    }
                    return false;
                }
            case 2:
                {
                    if (Medium > 0)
                    {
                        Medium--;
                        return true;
                    }
                    return false;
                }
            case 3:
                {
                    if (Small > 0) { Small--; return true; }
                    return false;
                }
            default: return false;
        }
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */