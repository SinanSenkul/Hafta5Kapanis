using System;

public class Car
{
	public DateTime ProdDate { get; set; }
    public string SerialNum {  get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int DoorType {  get; set; }
	public Car(string serialNum, string brand, string model, string color, int doorType)
	{
		ProdDate = DateTime.Now;
		SerialNum = serialNum;
		Brand = brand;
		Model = model;
		Color = color;
		DoorType = doorType;
	}
}
