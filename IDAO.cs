public interface IDAO {
    public string ConnectionString{ get; set; }
    public Guid SessionID{ get; set; }
    public Guid UserID{ get; set; }

    public List<T> Retrieve<T>(Guid id);
    public List<T> Delete<T>(T deleteObject);
    public List<T> Update<T>(T updateObject);
    public List<T> Create<T>(T newObject);
}