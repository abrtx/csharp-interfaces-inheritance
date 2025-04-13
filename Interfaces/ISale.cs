
namespace test {

    interface ISale {
	public decimal Total { get; set; }
	public decimal Tax { get; set; }
        public string GetInfo();
    }
}
