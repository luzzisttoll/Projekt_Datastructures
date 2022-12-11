namespace Common
{
    public interface IMyList
    {
        void SwitchNode3(Node argFirstNode, Node argSecondNode);
        void SetSortStrategy(SortStrategy sortStrategy);
        Node GetFirst();
        void Sort();
    }

}