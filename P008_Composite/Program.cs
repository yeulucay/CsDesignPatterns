using P008_Composite;

IMilitaryUnit soldier1 = new Soldier("John");
IMilitaryUnit soldier2 = new Soldier("Alice");

MilitaryUnit platoon = new MilitaryUnit();
platoon.AddMember(soldier1);    
platoon.AddMember(soldier2);

MilitaryUnit otherPlatoon = new MilitaryUnit();
otherPlatoon.AddMember(soldier2);

MilitaryUnit company = new MilitaryUnit();
company.AddMember(platoon);
company.AddMember(otherPlatoon);

company.ConductOperation();