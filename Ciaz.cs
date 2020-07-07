using System;
public class Ciaz : Engine, ICar
{
    private string _name ;
    public Ciaz(string name){
        this._name=name;

    }
    public string TransmissionType{
        get { return _name;}
        set { _name = value; }
    }

    public string Start()
    {
        return string.Format("Ciaz is Started");
    }
    public string Accelerate()
    {
        return string.Format("Ciaz is moving");
    }
    public string Stop()
    {
        return string.Format("Ciaz is Stoped");
    }

    public override void NewEngine()
    {
        Console.WriteLine("Petrol Engine is added");
    }
}