using System;
class Matrix{
    public static int[,] CreateRandomMatrix(int r,int c){
        int[,] a=new int[r,c];
        Random rand=new Random();
        for(int i=0;i<r;i++){
            for(int j=0;j<c;j++){
                a[i,j]=rand.Next(1,10);
            }
        }
        return a;
    }

    public static int[,] Add(int[,] a,int[,] b){
        int r=a.GetLength(0);
        int c=a.GetLength(1);
        int[,] res=new int[r,c];
        for(int i=0;i<r;i++){
            for(int j=0;j<c;j++){
                res[i,j]=a[i,j]+b[i,j];
            }
        }
        return res;
    }

    public static int[,] Subtract(int[,] a,int[,] b){
        int r=a.GetLength(0);
        int c=a.GetLength(1);
        int[,] res=new int[r,c];
        for(int i=0;i<r;i++){
            for(int j=0;j<c;j++){
                res[i,j]=a[i,j]-b[i,j];
            }
        }
        return res;
    }

    public static int[,] Multiply(int[,] a,int[,] b){
        int r=a.GetLength(0);
        int c=b.GetLength(1);
        int n=a.GetLength(1);
        int[,] res=new int[r,c];
        for(int i=0;i<r;i++){
            for(int j=0;j<c;j++){
                res[i,j]=0;
                for(int k=0;k<n;k++){
                    res[i,j]+=a[i,k]*b[k,j];
                }
            }
        }
        return res;
    }

    public static int[,] Transpose(int[,] a){
        int r=a.GetLength(0);
        int c=a.GetLength(1);
        int[,] res=new int[c,r];
        for(int i=0;i<r;i++){
            for(int j=0;j<c;j++){
                res[j,i]=a[i,j];
            }
        }
        return res;
    }

    public static void DisplayMatrix(int[,] a){
        int r=a.GetLength(0);
        int c=a.GetLength(1);
        for(int i=0;i<r;i++){
            for(int j=0;j<c;j++){
                Console.Write(a[i,j]+"\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main(){
        Console.WriteLine("Matrix A:");
        int[,] A=CreateRandomMatrix(2,2);
        DisplayMatrix(A);

        Console.WriteLine("Matrix B:");
        int[,] B=CreateRandomMatrix(2,2);
        DisplayMatrix(B);

        Console.WriteLine("A + B:");
        int[,] add=Add(A,B);
        DisplayMatrix(add);

        Console.WriteLine("A - B:");
        int[,] sub=Subtract(A,B);
        DisplayMatrix(sub);

        Console.WriteLine("A * B:");
        int[,] mul=Multiply(A,B);
        DisplayMatrix(mul);

        Console.WriteLine("Transpose of A:");
        int[,] trans=Transpose(A);
        DisplayMatrix(trans);
    }
}