using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Network_tao
{
    class NeuralNetwork
    {
        //มี Input 3 ค่า ก็ต้องสร้าง weight 3 ค่า
        double[] weight;

        //กำหนด คอนสทรัทเตอร์
        public NeuralNetwork()
        {
            Random rand = new Random();

            // สุ่มค่าเวทใส่ไป 3 ตัวในอาเรย์เพื่อเอาไว้ใช้งาน
            weight = new double[] { rand.NextDouble(), rand.NextDouble(), rand.NextDouble() };
        }

        public double predict(int[] neroun_inputs)
        {

        }


        //Trinin เอาไว้ใช้ในการปรับค่า weight
        public double[] train(List<TrainingSet> training_set_example,long number_of_iterations) 
        {
            
        }
            

        //  หาค่าผลรวมของ weight เพื่อนำไปใช้ในการคำนวนใน Activation function
        private double sum_of_weight_input(int[] neuron_inputs)
        {
            double sum_of_weigh_inputs = 0;
            for(int index=0; index<neuron_inputs.Length; index++)
            {
                sum_of_weigh_inputs += this.weight[index] * neuron_inputs[index];
            }
            return sum_of_weigh_inputs;
        }


        private double activation(double sum_of_weight_inputs)
        {
            //sigmoid function
            return 1 / (1 + Math.Exp(-sum_of_weight_inputs));

        }


        //เนื่องจากระหว่างเทรน ต้องใช้ค่า cost ฟังก์ชั่นในการปรับดังนั้นต้องสร้างเมธอดขึ้นมา
        private double error_cost(double output,double predicted)
        {
            
        }

        // ใช้สำหรับในการปรับแก้ไขค่าweight
        private double adjust_weight(double neuron_input,double error_in_output)
        {

        }

    }
}
