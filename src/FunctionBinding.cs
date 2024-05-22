using Boundless.OmniAdapter.Models;

namespace Boundless.OmniAdapter.Kernel;

public class FunctionBinding
{
  public Function Function { get; set; }
  public Delegate Action { get; set; }
  public FunctionBinding(Function fn, Delegate action)
  {
    this.Function = fn;
    this.Action = action;
  }
}