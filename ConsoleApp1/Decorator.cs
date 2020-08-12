namespace ConsoleApp1
{
    public abstract class Decorator : IecVar
    {
        protected IecVar iecVar; // この飾り枠がくるんでいる「中身」を指す

        protected Decorator(IecVar iecVar)
        { // インスタンス生成時に「中身」を引数で指定
            this.iecVar = iecVar;
        }
    }
}
