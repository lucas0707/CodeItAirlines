namespace CodeITAirlines.Actors
{
    public class Actor
    {
        public virtual string Name { get; set; }
    }

    public class Pilot : Actor
    {
        public override string Name { get; set; } = "Piloto";
    }

    public class Oficial : Actor
    {
        public override string Name { get; set; }
    }


    public class Chief : Actor
    {
        public override string Name { get; set; } = "Chefe de Servico de Bordo";
    }

    public class Attendant : Actor
    {
        public override string Name { get; set; }
    }

    public class Cop : Actor
    {
        public override string Name { get; set; } = "Policial";
    }

    public class Prisoner : Actor
    {
        public override string Name { get; set; } = "Prisioneiro";
    }
}
