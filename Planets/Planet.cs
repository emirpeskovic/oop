using MoreEverything;

namespace Planets
{
    public class Planet
    {
        private string planetName;
        /// <summary>
        /// Name of the planet
        /// </summary>
        /// <value>string</value>
        public string PlanetName
        {
            get => planetName;
            private set => planetName = value;
        }
        
        private double mass;
        /// <summary>
        /// Mass in kilograms
        /// </summary>
        /// <returns>double</returns>
        public double Mass
        {
            get => mass;
            private set => mass = value;
        }

        private Distance diameter;
        /// <summary>
        /// Diameter in Distance object
        /// </summary>
        /// <returns>Distance</returns>
        public Distance Diameter
        {
            get => diameter;
            private set { diameter = value; }
        }

        private double density;
        /// <summary>
        /// Density in kilograms per cubic meter
        /// </summary>
        /// <returns>double</returns>
        public double Density
        {
            get => density;
            private set => density = value;
        }

        private double gravity;
        /// <summary>
        /// Gravity in meters per second squared
        /// </summary>
        /// <returns>double</returns>
        public double Gravity
        {
            get => gravity;
            private set => gravity = value;
        }
        
        private Time rotationPeriod;
        /// <summary>
        /// Rotation period in Time
        /// </summary>
        /// <returns>Time</returns>
        public Time RotationPeriod
        {
            get => rotationPeriod;
            private set => rotationPeriod = value;
        }

        private Time lengthOfDay;
        /// <summary>
        /// Length of day in Time
        /// </summary>
        /// <returns>Time</returns>
        public Time LengthOfDay
        {
            get => lengthOfDay;
            private set => lengthOfDay = value;
        }
        
        private Distance distanceFromSun;
        /// <summary>
        /// Distance from sun in Distance
        /// </summary>
        /// <returns>Distance</returns>
        public Distance DistanceFromSun
        {
            get => distanceFromSun;
            private set => distanceFromSun = value;
        }

        private Time orbitalPeriod;
        /// <summary>
        /// Orbital period in Time
        /// </summary>
        /// <returns>Time</returns>
        public Time OrbitalPeriod
        {
            get => orbitalPeriod;
            private set => orbitalPeriod = value;
        }
        
        private double orbitalVelocity;
        /// <summary>
        /// Orbital velocity in kilometers per second
        /// </summary>
        /// <returns>double</returns>
        public double OrbitalVelocity
        {
            get => orbitalVelocity;
            private set => orbitalVelocity = value;
        }
        
        private int meanTemperature;
        /// <summary>
        /// Mean temperature in celcius
        /// </summary>
        /// <returns>int</returns>
        public int MeanTemperature
        {
            get => meanTemperature;
            private set => meanTemperature = value;
        }
        
        private int moons;
        /// <summary>
        /// Amount of moons
        /// </summary>
        /// <returns>int</returns>
        public int Moons
        {
            get => moons;
            private set => moons = value;
        }
        
        private bool ringSystem;
        /// <summary>
        /// Has a ring system?
        /// </summary>
        /// <returns>bool</returns>
        public bool RingSystem
        {
            get => ringSystem;
            private set => ringSystem = value;
        }

        public Planet(string name, double mass, Distance diameter, double density, double gravity, Time rotationPeriod, Time lengthOfDay, Distance distanceFromSun, Time orbitalPeriod, double orbitalVelocity, int meanTemperature, int moons, bool ringSystem)
        {
            PlanetName = name;
            Mass = mass;
            Diameter = diameter;
            Density = density;
            Gravity = gravity;
            RotationPeriod = rotationPeriod;
            LengthOfDay = lengthOfDay;
            DistanceFromSun = distanceFromSun;
            OrbitalPeriod = orbitalPeriod;
            OrbitalVelocity = OrbitalVelocity;
            MeanTemperature = meanTemperature;
            Moons = moons;
            RingSystem = ringSystem;
        }
    }
}