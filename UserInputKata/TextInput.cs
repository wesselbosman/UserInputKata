namespace UserInputKata
{
	public class TextInput
	{
		public string CurrentValue = string.Empty;

		public virtual void Add(char character)
		{
			CurrentValue += character;
		}

		public string GetValue()
		{
			return CurrentValue;
		}
	}
}