namespace QuantumMC.Blocks
{
    public class BlockLava : Block
    {
        public static int ID { get; internal set; }
        public override int RuntimeId => ID;

        public BlockDirt() : base("minecraft:lava") { }
    }
}
