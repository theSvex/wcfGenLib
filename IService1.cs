using GAF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfGenLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IGenLib
    {
        //[OperationContract]
        void ga_OnGenerationComplete(object sender, GaEventArgs e);

        [OperationContract]
        bool TerminateAlgorithm(Population population, int currentGeneration, long currentEvaluation);

        [OperationContract]
        double EvaluateFitness(Chromosome chrom);

        [OperationContract]
        FittestValue Start(double crossoverProb, double mutationProb, int elitismPerc, int perPopulation, int populationCount);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "wcfGenLib.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
