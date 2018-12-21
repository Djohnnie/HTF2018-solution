using HTF2018.Solution.Model;
using System.Collections.Generic;

namespace HTF2018.Solution.Logic
{
    public class ChallengeSolver
    {
        private readonly Dictionary<Identifier, IChallenge> _challenges = new Dictionary<Identifier, IChallenge>
        {
            { Identifier.Challenge02, new Challenge02() },
            { Identifier.Challenge03, new Challenge03() },
            { Identifier.Challenge04, new Challenge04() },
            { Identifier.Challenge05, new Challenge05() },
            { Identifier.Challenge06, new Challenge06() },
            { Identifier.Challenge07, new Challenge07() },
            { Identifier.Challenge08, new Challenge08() },
            { Identifier.Challenge09, new Challenge09() },
            { Identifier.Challenge10, new Challenge10() },
            { Identifier.Challenge11, new Challenge11() },
            { Identifier.Challenge12, new Challenge12() },
            { Identifier.Challenge13, new Challenge13() },
            { Identifier.Challenge14, new Challenge14() },
            { Identifier.Challenge15, new Challenge15() },
            { Identifier.Challenge16, new Challenge16() },
            { Identifier.Challenge17, new Challenge17() },
            { Identifier.Challenge18, new Challenge18() },
            { Identifier.Challenge19, new Challenge19() },
            { Identifier.Challenge20, new Challenge20() },
        };

        public List<Value> Solve(Identifier identifier, List<Value> inputValues)
        {
            var challenge = _challenges[identifier];
            return challenge.Solve(inputValues);
        }
    }
}