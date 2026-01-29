using System.Collections.Generic;

public class BikeUtility
{
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        Bike bike = new Bike();
        bike.Model = model;
        bike.Brand = brand;
        bike.PricePerDay = pricePerDay;

        int key = Program.bikeDetails.Count + 1;
        Program.bikeDetails.Add(key, bike);
    }

    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> result =
            new SortedDictionary<string, List<Bike>>();

        List<Bike> allBikes = new List<Bike>(Program.bikeDetails.Values);

        for (int i = 0; i < allBikes.Count; i++)
        {
            Bike bike = allBikes[i];

            if (!result.ContainsKey(bike.Brand))
            {
                result[bike.Brand] = new List<Bike>();
            }
            result[bike.Brand].Add(bike);
        }
        return result;
    }
}