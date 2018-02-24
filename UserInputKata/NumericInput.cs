namespace UserInputKata
{
	public class NumericInput : TextInput
	{
		public override void Add(char character)
		{
			if (int.TryParse(character.ToString(), out var numeric))
			{
				CurrentValue += numeric.ToString();
			}
		}
	}
}