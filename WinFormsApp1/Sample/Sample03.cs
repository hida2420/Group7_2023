using System;
using KelpNet.CL;
using KelpNet;
using System.Diagnostics;

#if DOUBLE
#elif NETCOREAPP2_0
using Math = System.MathF;
#else
using Math = System.MathF;
#endif

//using Real = System.Double;
using Real = System.Single;

namespace WinFormsApp1
{
    using System.Diagnostics;
    //MLPによるSin関数の学習

    //学習対象の周期を増やしたり、サンプリング数(N)を増やすとスコアが悪化するので、
    //課題として挑戦してみると良いかもしれない
    class Sample03
    {
        //学習回数
        const int EPOCH = 1000;

        //一周期の分割数
        const int N = 50;

        public static void Run()
        {
            Real[][] trainData = new Real[N][];
            Real[][] trainLabel = new Real[N][];

            for (int i = 0; i < N; i++)
            {
                //Sin波を一周期分用意
                Real radian = -Math.PI + Math.PI * 2.0f * i / (N - 1);
                trainData[i] = new[] { radian };
                trainLabel[i] = new Real[] { Math.Sin(radian) };
            }

            //ネットワークの構成を FunctionStack に書き連ねる
            FunctionStack<Real> nn = new FunctionStack<Real>(
                new Linear<Real>(1, 4, name: "l1 Linear"),
                new TanhActivation<Real>(name: "l1 Tanh"),
                new Linear<Real>(4, 1, name: "l2 Linear")
            );

            //訓練ループ
            for (int i = 0; i < EPOCH; i++)
            {
                //誤差集計用
                Real loss = 0;

                for (int j = 0; j < N; j++)
                {
                    //ネットワークは訓練を実行すると戻り値に誤差が返ってくる
                    loss += Trainer.Train(nn, trainData[j], trainLabel[j], new MeanSquaredError<Real>(), new SGD<Real>(0.1f));
                }

                if (i % (EPOCH / 10) == 0)
                {
                    Debug.WriteLine("loss:" + loss / N);
                    Debug.WriteLine("");
                }
            }

            //訓練結果を表示
            Debug.WriteLine("Test Start...");

            foreach (Real[] val in trainData)
            {
                Debug.WriteLine(val[0] + ":" + nn.Predict(val)[0].Data[0]);
            }
        }
    }
}
