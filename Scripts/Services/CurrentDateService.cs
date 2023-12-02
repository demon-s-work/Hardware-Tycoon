using System;
using Godot;

namespace HardwareTycoon.Scripts.Services
{
	public partial class CurrentDateService : Node
	{
		private DateTime _currentDateTime = DateTime.UnixEpoch;
		private double _deltaCounter;
		private const double CounterStep = 1;
		private readonly TimeSpan _speed = TimeSpan.FromDays(7);
		
		[Signal]
		public delegate void CurrentDateChangedEventHandler(long old, long @new);
			
		public override void _Ready()
		{
			base._Ready();
		}
		
		public override void _Process(double delta)
		{
			base._Process(delta);
			_deltaCounter += delta;

			if (_deltaCounter >= CounterStep)
			{
				_deltaCounter -= CounterStep;
				var oldDateTime = _currentDateTime;
				_currentDateTime = _currentDateTime.Add(_speed);

				EmitSignal(SignalName.CurrentDateChanged, oldDateTime.ToBinary(), _currentDateTime.ToBinary());
			}

		}
	}
}