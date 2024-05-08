using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_DamienAd
{
        //New class to get and set the make and model of cars
        class Car
        {

            private string model;

            public string Model { get { return model; } set { model = value; } }

            public string Make { get; set; }

        }
    }

