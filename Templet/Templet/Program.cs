using System;

namespace Templet
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
            Caffe caffe = new Caffe();
            tea.Prepare();
            caffe.Prepare();
        }
    }
}
