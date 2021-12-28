namespace State
{
    public class TextEditor
    {

        private IWritingState mState;

        public TextEditor()
        {
            mState = new DefaultText();
        }

        public void SetState(IWritingState state)
        {
            mState = state;
        }

        public void Type(string words)
        {
            mState.Write(words);
        }
    }
}
