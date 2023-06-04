using FacadePattern;
using FacadePattern.SubsystemClasses;

DisplayDataFacade facade = new DisplayDataFacade(new Data(), new Formatter(), new Presentation());

facade.RenderAllData();
