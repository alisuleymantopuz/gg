namespace gg.core
{
    public class GroupIdGenerator : IGroupIdGenerator
    {
        private long _currentId = 1;

        public long Next()
        {
            return ++_currentId;
        }
    }
}
