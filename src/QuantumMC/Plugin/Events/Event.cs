namespace QuantumMC.Plugin.Events;

public abstract class Event {
    
    public bool IsCancelled { get; private set; }

    public void Cancel() {
        IsCancelled = true;
    }
}