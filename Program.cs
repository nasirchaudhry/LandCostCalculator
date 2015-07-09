using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//start NameSpace LandCostCalculator
namespace LandCostCalculator
{
    /// <summary> 
    /// This program will take the length and width values of a land from user and calculate the area 
    /// and perimeter and will print out the total cost of the land
    /// </summary>

    //start class Program
    class Program
    {
        //start main function
        static void Main(string[] args)
        {
            //declare variables            
            double length = 0;
            double width = 0;
            double landCost = 0;
            double parcelArea = 0;
            double parcelPerimeter = 0;

            //prompt user to enter the length
            Console.WriteLine( "Please enter the length in feet: " );
            length = double.Parse ( Console.ReadLine() );
            Console.WriteLine( "" );

            //prompt user to enter the width
            Console.WriteLine( "Please enter the width in feet: " );
            width = double.Parse ( Console.ReadLine() );
            Console.WriteLine( "" );

            //algorithm to calculate area and convert to square yard
            parcelArea = ( length * width ) / 9;

            //algorithm to calculate perimeter
            parcelPerimeter = ( length * 2 + width * 2 );

            //algorithm to calculate cost of the land
            landCost = ( parcelArea * 5 ) + ( parcelPerimeter * 0.75 );

            //print out the cost of the land
            Console.WriteLine( "The Cost of the Land is: " + landCost.ToString( "C2" ) );
            Console.ReadLine();
        }//end main
    }//end class program
}//end namespace LandCostCalculator