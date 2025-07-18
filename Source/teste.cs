using Verse;
using RimWorld;

namespace MeuMod
{
    public class MeuModGameComponent : GameComponent
    {
        public MeuModGameComponent(Game game) : base() { }

        public override void FinalizeInit()
        {
            base.FinalizeInit();

            // Corrigido: agora usamos IReadOnlyList<Pawn>
            var todosPawns = PawnsFinder.AllMaps_Spawned;

            foreach (Pawn p in todosPawns)
            {
                if (p.Faction != null && p.Faction.IsPlayer)
                {
                    Log.Message($"[MeuMod] Colono: {p.Name.ToStringFull}");
                }
            }
        }
    }
}
