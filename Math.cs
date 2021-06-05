namespace WasmMath {
  using Wasmtime;

  public class Math {
    private Engine engine;
    private Module module;
    private Host host;
    private dynamic instance;

    public Math() {
      this.engine = new EngineBuilder().WithReferenceTypes(true).Build();
      this.module = Module.FromTextFile(engine, "math.wat");
      this.host = new Host(engine);
      this.instance = host.Instantiate(module);
    }

    public int Add(int a, int b) {
      return instance.add(a, b);
    }

    public int Subtract(int a, int b) {
      return instance.sub(a, b);
    }
  }
}