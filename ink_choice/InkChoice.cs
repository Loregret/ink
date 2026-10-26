using Godot;
using System.Collections.Generic;

namespace GodotInk;

[Tool, GlobalClass]
public partial class InkChoice : RefCounted
{
	public string Text => _inner.text;
	public int Index => _inner.index;

	public string PathStringOnChoice => _inner.pathStringOnChoice;
	public string SourcePath => _inner.sourcePath;

	public IReadOnlyList<string> Tags => _inner.tags ?? (IReadOnlyList<string>)[];

	readonly Ink.Runtime.Choice _inner;

	InkChoice()
	{
		_inner = new Ink.Runtime.Choice();
	}

	public InkChoice(Ink.Runtime.Choice inner)
	{
		_inner = inner;
	}

	public override string ToString() => $"{Index}: {Text}";
}
