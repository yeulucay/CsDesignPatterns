namespace P008_Composite
{
    public interface IMilitaryUnit
    {
        void ConductOperation();
        string ToString();
    }

    public class MilitaryUnit : IMilitaryUnit
    {
        private List<IMilitaryUnit> members = new();

        public void AddMember(IMilitaryUnit member)
        {
            members.Add(member);
        }

        public void ConductOperation()
        {
            Console.WriteLine("Commanding the militar unit to conduct an operation");
            
            foreach (var member in members)
            {
                member.ConductOperation();
            }
        }
    }

    public class Soldier : IMilitaryUnit
    {
        private string name;

        public Soldier(string name)
        {
            this.name = name;
        }

        public void ConductOperation() 
        {
            Console.WriteLine($"Soldier {name} is performing a specific task.");
        }
    }
}
