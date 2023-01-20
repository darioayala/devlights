

using WorkDay.Business;
using WorkDay.Infrastructure;

var building = DataInitialization.Initialize();

if (building is null) return;


var handler = new WorkDayHandler();

handler.StartWorkingDay(building);

