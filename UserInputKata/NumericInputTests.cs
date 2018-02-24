using NUnit.Framework;

namespace UserInputKata
{
	[TestFixture]
	public class NumericInputTests
	{
		private NumericInput _numericInput;

		[SetUp]
		public void Setup()
		{
			_numericInput = new NumericInput();
		}

		[Test]
		public void NumericInput_InheritsFromTextInput()
		{
			var textInput = _numericInput as TextInput;

			Assert.That(textInput, Is.Not.Null, "NumericInput can't be cast to TextInput - NumericInput should inherit from TextInput");
		}

		[Test]
		public void Add_GivenNonNumericCharacter_ShouldNotAddToCurrentValue()
		{
			// Act
			_numericInput.Add('1');
			_numericInput.Add('a');
			_numericInput.Add('0');
			var value = _numericInput.GetValue();

			// Assert
			Assert.That(value, Is.EqualTo("10"));
		}
	}
}
