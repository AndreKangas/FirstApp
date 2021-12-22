using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace FirstApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/MyTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView firstText;
        TextView textViewResult;
        EditText firstNumberEditText;
        EditText secondNumberEditText;
        Button buttonAdd;
        Button buttonSubtract;
        Button buttonMultiply;
        Button buttonDivide;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            firstText = FindViewById<TextView>(Resource.Id.textView1);
            //var firstButton = FindViewById<Button>(Resource.Id.button1);
            firstNumberEditText = FindViewById<EditText>(Resource.Id.editText1);
            secondNumberEditText = FindViewById<EditText>(Resource.Id.editText2);
            buttonAdd = FindViewById<Button>(Resource.Id.buttonAdd);
            buttonSubtract = FindViewById<Button>(Resource.Id.buttonSubtract);
            buttonMultiply = FindViewById<Button>(Resource.Id.buttonMultiply);
            buttonDivide = FindViewById<Button>(Resource.Id.buttonDivide);
            textViewResult = FindViewById<TextView>(Resource.Id.textViewResult);
            buttonAdd.Click += ButtonAdd_Click;
            buttonSubtract.Click += ButtonSubtract_Click;
            buttonMultiply.Click += ButtonMultiply_Click;
            buttonDivide.Click += ButtonDivide_Click;


            firstText.Text = "This is a Calculator";
            //firstButton.Text = "Just Do It!";
            //firstButton.Click += FirstButton_Click;
        }

        private void ButtonDivide_Click(object sender, System.EventArgs e)
        {
            var firstNumber = double.Parse(firstNumberEditText.Text);
            var secondNumber = double.Parse(secondNumberEditText.Text);
            var answer = firstNumber / secondNumber;

            textViewResult.Text = answer.ToString();
        }

        private void ButtonMultiply_Click(object sender, System.EventArgs e)
        {
            var firstNumber = double.Parse(firstNumberEditText.Text);
            var secondNumber = double.Parse(secondNumberEditText.Text);
            var answer = firstNumber * secondNumber;

            textViewResult.Text = answer.ToString();
        }

        private void ButtonSubtract_Click(object sender, System.EventArgs e)
        {
            var firstNumber = double.Parse(firstNumberEditText.Text);
            var secondNumber = double.Parse(secondNumberEditText.Text);
            var answer = firstNumber - secondNumber;

            textViewResult.Text = answer.ToString();
        }

        private void ButtonAdd_Click(object sender, System.EventArgs e)
        {
            var firstNumber = double.Parse(firstNumberEditText.Text);
            var secondNumber = double.Parse(secondNumberEditText.Text);
            var answer = firstNumber + secondNumber;

            textViewResult.Text = answer.ToString();
        }

        //private void FirstButton_Click(object sender, System.EventArgs e)
        //{
        //        firstText.Text = "Why are you clicking?";

        //}

        //protected override void OnStart()
        //{
        //    base.OnStart();
        //}

        //protected override void OnPause()
        //{
        //    base.OnPause();
        //}
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}