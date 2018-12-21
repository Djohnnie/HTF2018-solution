using HTF2018.Solution.Model;
using System.Collections.Generic;

namespace HTF2018.Solution.Logic
{
    public class ChallengeSolver
    {
        private readonly Dictionary<Identifier, IChallenge> _challenges = new Dictionary<Identifier, IChallenge>
        {
            { Identifier.Challenge02, new Challenge02() },
        };

        public List<Value> Solve(Identifier identifier, List<Value> inputValues)
        {
            var challenge = _challenges[identifier];
            return challenge.Solve(inputValues);
        }
    }
}