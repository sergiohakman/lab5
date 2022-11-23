using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
  public enum Gender { Male, Female };
  public class Cat
  {
    
    string name;

    public string Name
    {
      get { return name; }
      
    }
    public Gender CatGender { get; }
    double _energy;
    public double Energy
    {
      get { return _energy; }
      set {
        if (value > MaxEnergy)
        {
          _energy = MaxEnergy;
        }
        else if (value <= MinEnergy)
        {
          Console.WriteLine("Not enough energy to jump");
        }
        else
        {
          _energy = value;
        }
          }
    }
    public static double MaxEnergy = 20;

    public static double MinEnergy = 0;

    public static double SleepEnergyGain = 10;

    public static double JumpEnergyDrain = 0.5;
    public Cat (string Name, Gender gender) 
    {
      this.name = Name;
      this.CatGender = gender;
      this._energy = MaxEnergy;
    }
    public void Jump()
    {

      Energy -= JumpEnergyDrain;
      Console.WriteLine("В кота " + name +" енергії залишилося: "+ Energy);
    }
    public void Sleep()
    {
      Energy += SleepEnergyGain;

      Console.WriteLine("В кота " +name+" енергії залишилося: "+Energy);
    }
  }
}
