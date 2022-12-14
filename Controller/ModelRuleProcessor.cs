using static InferenceLibrary.Severity;

namespace InferenceLibrary
{
    public class ModelRuleProcessor
    {        
        public Severity ActivateRule(FuzzyTuple fuzzyTuple) =>
            (fuzzyTuple.ApplicationGrade.Key, fuzzyTuple.PresentationGrade.Key, fuzzyTuple.ArrangementGrade.Key) switch
            {
                //If ML is %% and CS is %% and CS2 is %% then ADIN is %%
                (Terrible, Terrible, Terrible) => Terrible,         //1
                (Terrible, Terrible, Bad) => Terrible,           //2
                (Terrible, Terrible, Good) => Terrible,       //3
                (Terrible, Terrible, Excellent) => Terrible,         //4
                (Terrible, Bad, Terrible) => Terrible,           //5
                (Terrible, Good, Terrible) => Terrible,       //6
                (Terrible, Excellent, Terrible) => Terrible,         //7
                (Terrible, Bad, Bad) => Terrible,             //8
                (Terrible, Bad, Good) => Terrible,         //9
                (Terrible, Bad, Excellent) => Terrible,           //10
                (Terrible, Good, Bad) => Terrible,         //11
                (Terrible, Excellent, Bad) => Terrible,           //12
                (Terrible, Good, Good) => Terrible,     //13
                (Terrible, Good, Excellent) => Bad,         //14
                (Terrible, Excellent, Good) => Bad,         //15
                (Terrible, Excellent, Excellent) => Bad,           //16
                (Bad, Terrible, Terrible) => Terrible,           //17
                (Bad, Terrible, Bad) => Terrible,             //18
                (Bad, Terrible, Good) => Bad,           //19
                (Bad, Terrible, Excellent) => Bad,             //20
                (Bad, Bad, Terrible) => Terrible,             //21
                (Bad, Good, Terrible) => Bad,           //22
                (Bad, Excellent, Terrible) => Bad,             //23
                (Bad, Bad, Bad) => Bad,                 //24
                (Bad, Bad, Good) => Bad,             //25
                (Bad, Bad, Excellent) => Good,           //26
                (Bad, Good, Bad) => Bad,             //27
                (Bad, Excellent, Bad) => Good,           //28
                (Bad, Good, Good) => Good,     //29
                (Bad, Good, Excellent) => Good,       //30
                (Bad, Excellent, Good) => Good,       //31
                (Bad, Excellent, Excellent) => Good,         //32
                (Good, Terrible, Terrible) => Bad,         //33
                (Good, Terrible, Bad) => Bad,           //34
                (Good, Terrible, Good) => Good,   //35
                (Good, Terrible, Excellent) => Good,     //36
                (Good, Bad, Terrible) => Bad,           //37
                (Good, Good, Terrible) => Bad,       //38
                (Good, Excellent, Terrible) => Good,     //39
                (Good, Bad, Bad) => Bad,             //40
                (Good, Bad, Good) => Good,     //41
                (Good, Bad, Excellent) => Excellent,         //42
                (Good, Good, Bad) => Good,     //43
                (Good, Excellent, Bad) => Excellent,         //44
                (Good, Good, Good) => Good, //45
                (Good, Good, Excellent) => Excellent,     //46
                (Good, Excellent, Good) => Excellent,     //47
                (Good, Excellent, Excellent) => Excellent,       //48
                (Excellent, Terrible, Terrible) => Good,       //49
                (Excellent, Terrible, Bad) => Good,         //50
                (Excellent, Terrible, Good) => Excellent,       //51
                (Excellent, Terrible, Excellent) => Excellent,         //52
                (Excellent, Bad, Terrible) => Good,         //53
                (Excellent, Good, Terrible) => Excellent,       //54
                (Excellent, Excellent, Terrible) => Excellent,         //55
                (Excellent, Bad, Bad) => Good,           //56
                (Excellent, Bad, Good) => Excellent,         //57
                (Excellent, Bad, Excellent) => Excellent,           //58
                (Excellent, Good, Bad) => Excellent,         //59
                (Excellent, Excellent, Bad) => Excellent,           //60
                (Excellent, Good, Good) => Excellent,     //61
                (Excellent, Good, Excellent) => Excellent,       //62
                (Excellent, Excellent, Good) => Excellent,       //63
                (Excellent, Excellent, Excellent) => Excellent,         //64
            };
    }
}
