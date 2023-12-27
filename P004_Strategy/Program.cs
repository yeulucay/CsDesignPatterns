using P004_Strategy;

var planner1 = new TravelPlanner(new CarTravel());
planner1.DoPlan("Michigan", "Wisconsin");

var planner2 = new TravelPlanner(new PlaneTravel());
planner2.DoPlan("Florida", "Arizona");

var planner3 = new TravelPlanner(new TrainTravel());
planner3.DoPlan("New York", "Tennessee");