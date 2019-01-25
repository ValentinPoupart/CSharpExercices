using System;
using System.Collections.Generic;

namespace CS.Impl._04_Advanced
{
    public class Travel
    {
        public TravelRoadmap BuildTravelRoadmap(City initial, City destination)
        {
            TravelRoadmap travelRoadmap = new TravelRoadmap();
            var result = new List<TransportMode>();

            //if (initial.Equals(destination))
            //{
            //    result.Add(TransportMode.Foot);
            //    result.Add(TransportMode.Car);
            //    result.Add(TransportMode.Train);
            //}
            //else if (initial.Equals(City.Sydney) || destination.Equals(City.Sydney))
            //{
            //    result.Add(TransportMode.Boat);
            //    result.Add(TransportMode.Plane);
            //}
            //else
            //{
            //    result.Add(TransportMode.Plane);
            //    result.Add(TransportMode.Car);
            //    result.Add(TransportMode.Train);
            //}

            switch (initial)
            {
                case City.Barcelona:
                    switch (destination)
                    {
                        case City.Barcelona:
                            result.Add(TransportMode.Foot);
                            result.Add(TransportMode.Car);
                            result.Add(TransportMode.Train);
                            break;
                        case City.London:
                            result.Add(TransportMode.Plane);
                            result.Add(TransportMode.Car);
                            result.Add(TransportMode.Train);
                            break;
                        case City.Sydney:
                            result.Add(TransportMode.Boat);
                            result.Add(TransportMode.Plane);
                            break;
                        default:
                            throw new Exception("Not implemented");
                    }
                    break;
                case City.London:
                    switch (destination)
                    {
                        case City.Barcelona:
                            result.Add(TransportMode.Plane);
                            result.Add(TransportMode.Car);
                            result.Add(TransportMode.Train);
                            break;
                        case City.London:
                            result.Add(TransportMode.Foot);
                            result.Add(TransportMode.Car);
                            result.Add(TransportMode.Train);
                            break;
                        case City.Sydney:
                            result.Add(TransportMode.Boat);
                            result.Add(TransportMode.Plane);
                            break;
                        default:
                            throw new Exception("Not implemented");
                    }
                    break;
                case City.Sydney:
                    switch (destination)
                    {
                        case City.Barcelona:
                            result.Add(TransportMode.Boat);
                            result.Add(TransportMode.Plane);
                            break;
                        case City.London:
                            result.Add(TransportMode.Boat);
                            result.Add(TransportMode.Plane);
                            break;
                        case City.Sydney:
                            result.Add(TransportMode.Foot);
                            result.Add(TransportMode.Car);
                            result.Add(TransportMode.Train);
                            break;
                        default:
                            throw new Exception("Not implemented");
                    }
                    break;
                default:
                    throw new Exception("Not implemented");
            }
            travelRoadmap.Modes = result;
            return travelRoadmap;
        }
    }

    public class TravelRoadmap
    {
        public IEnumerable<TransportMode> Modes { get; set; }
    }

    public enum City
    {
        Barcelona,
        London,
        Sydney
    }

    public enum TransportMode
    {
        Foot,
        Car,
        Train,
        Boat,
        Plane
    }

    public class DistanceHelper
    {
        public Distance GetDistance(City initial, City destination)
        {
            //if (initial.Equals(destination))
            //{
            //    return Distance.Short;
            //}
            //else if (initial.Equals(City.Sydney) || destination.Equals(City.Sydney))
            //{
            //    return Distance.Long;
            //}
            //else
            //{
            //    return Distance.Medium;
            //}

            switch (initial)
            {
                case City.Barcelona:
                    switch (destination)
                    {
                        case City.Barcelona:
                            return Distance.Short;
                        case City.London:
                            return Distance.Medium;
                        case City.Sydney:
                            return Distance.Long;
                        default:
                            throw new Exception("Not implemented");
                    }
                case City.London:
                    switch (destination)
                    {
                        case City.Barcelona:
                            return Distance.Medium;
                        case City.London:
                            return Distance.Short;
                        case City.Sydney:
                            return Distance.Long;
                        default:
                            throw new Exception("Not implemented");
                    }
                case City.Sydney:
                    switch (destination)
                    {
                        case City.Barcelona:
                            return Distance.Long;
                        case City.London:
                            return Distance.Long;
                        case City.Sydney:
                            return Distance.Short;
                        default:
                            throw new Exception("Not implemented");
                    }
                default:
                    throw new Exception("Not implemented");
            }
        }
    }

    public enum Distance
    {
        Short,
        Medium,
        Long
    }
}