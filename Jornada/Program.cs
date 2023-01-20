

using WorkDay.Business;
using WorkDay.Infrastructure;

var building = DataInitialization.Initialize();
var handler = new WorkDayHandler();

handler.StartWorkingDay(building);

