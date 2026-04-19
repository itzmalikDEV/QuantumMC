namespace QuantumMC.Blocks
{
    public class BlockDeepslate : Block
    {
        public static int ID { get; internal set; }
        public override int RuntimeId => ID;

        public BlockDirt() : base("minecraft:deepslate") { }
    }
}
