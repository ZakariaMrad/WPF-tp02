using System.Windows.Input;

namespace tp2.partieB___jeremy
{
    public class VenteBillets
    {
        public int Id { get; set; }
        public string Temps { get; set; }

        public ICommand Command { get; set; }

        public VenteBillets (int id, string temps, ICommand command)
        {
            Id = id;
            Temps = temps;
            Command = command;
        }
    }
}