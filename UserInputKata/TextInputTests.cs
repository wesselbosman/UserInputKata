using NUnit.Framework;

namespace UserInputKata
{
	[TestFixture]
	public class TextInputTests
	{
		private TextInput _textInput;

		[SetUp]
		public void Setup()
		{
			_textInput = new TextInput();
		}

		[Test]
		public void Add_GivenCharacter_AddsTheGivenCharacterToTheCurrentValue()
		{
			// Arrange
			const char char1 = 'd';
			const char char2 = 'o';

			// Act
			_textInput.Add(char1);
			_textInput.Add(char2);

			// Asserts
			Assert.That(_textInput.CurrentValue, Is.EqualTo("do"));
		}

		[Test]
		public void GetValue_ReturnsCurrentValue()
		{
			// Arrange
			_textInput.Add('a');

			// Act
			var value = _textInput.GetValue();

			// Assert
			Assert.That(value, Is.EqualTo("a"));
		}
	}
}