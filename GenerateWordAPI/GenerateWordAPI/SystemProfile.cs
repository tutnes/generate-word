using System.Xml.Serialization;
using System.Collections.Generic;

namespace GenerateWordAPI

{
    [XmlRoot(ElementName = "technology")]
    public class Technology
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "sensor")]
    public class Sensor
    {
        [XmlAttribute(AttributeName = "defaultorder")]
        public string Defaultorder { get; set; }
        [XmlAttribute(AttributeName = "jssensorttype")]
        public string Jssensorttype { get; set; }
        [XmlAttribute(AttributeName = "featurehash")]
        public string Featurehash { get; set; }
        [XmlAttribute(AttributeName = "hint")]
        public string Hint { get; set; }
        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "autoplace")]
        public string Autoplace { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }
        [XmlAttribute(AttributeName = "userdefined")]
        public string Userdefined { get; set; }
        [XmlAttribute(AttributeName = "group")]
        public string Group { get; set; }
        [XmlAttribute(AttributeName = "order")]
        public string Order { get; set; }
    }

    [XmlRoot(ElementName = "sensorgroup")]
    public class Sensorgroup
    {
        [XmlElement(ElementName = "sensor")]
        public Sensor Sensor { get; set; }
    }

    [XmlRoot(ElementName = "sensorgroups")]
    public class Sensorgroups
    {
        [XmlElement(ElementName = "sensorgroup")]
        public List<Sensorgroup> Sensorgroup { get; set; }
    }

    [XmlRoot(ElementName = "perfmonperformancecounter")]
    public class Perfmonperformancecounter
    {
        [XmlAttribute(AttributeName = "instance")]
        public string Instance { get; set; }
        [XmlAttribute(AttributeName = "performancecounter")]
        public string Performancecounter { get; set; }
        [XmlAttribute(AttributeName = "performanceobject")]
        public string Performanceobject { get; set; }
    }

    [XmlRoot(ElementName = "color")]
    public class Color
    {
        [XmlAttribute(AttributeName = "color.blue")]
        public string ColorBlue { get; set; }
        [XmlAttribute(AttributeName = "color.red")]
        public string ColorRed { get; set; }
        [XmlAttribute(AttributeName = "color.green")]
        public string ColorGreen { get; set; }
    }

    [XmlRoot(ElementName = "measure")]
    public class Measure
    {
        [XmlElement(ElementName = "perfmonperformancecounter")]
        public Perfmonperformancecounter Perfmonperformancecounter { get; set; }
        [XmlElement(ElementName = "color")]
        public Color Color { get; set; }
        [XmlAttribute(AttributeName = "servicecontext")]
        public string Servicecontext { get; set; }
        [XmlAttribute(AttributeName = "isaggregated")]
        public string Isaggregated { get; set; }
        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "displayaggregations")]
        public string Displayaggregations { get; set; }
        [XmlAttribute(AttributeName = "measuretype")]
        public string Measuretype { get; set; }
        [XmlAttribute(AttributeName = "pathaggregatepercentiles")]
        public string Pathaggregatepercentiles { get; set; }
        [XmlAttribute(AttributeName = "errortype")]
        public string Errortype { get; set; }
        [XmlAttribute(AttributeName = "metricgroupid")]
        public string Metricgroupid { get; set; }
        [XmlAttribute(AttributeName = "metricid")]
        public string Metricid { get; set; }
        [XmlAttribute(AttributeName = "rate")]
        public string Rate { get; set; }
        [XmlAttribute(AttributeName = "calculatebaseline")]
        public string Calculatebaseline { get; set; }
        [XmlAttribute(AttributeName = "errorseverity")]
        public string Errorseverity { get; set; }
        [XmlAttribute(AttributeName = "isapplicationaggregated")]
        public string Isapplicationaggregated { get; set; }
        [XmlAttribute(AttributeName = "createdtimestamp")]
        public string Createdtimestamp { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "displayunit")]
        public string Displayunit { get; set; }
        [XmlAttribute(AttributeName = "userdefined")]
        public string Userdefined { get; set; }
        [XmlAttribute(AttributeName = "calculatepercentiles")]
        public string Calculatepercentiles { get; set; }
        [XmlAttribute(AttributeName = "ischartable")]
        public string Ischartable { get; set; }
        [XmlElement(ElementName = "actiongeoinfo")]
        public Actiongeoinfo Actiongeoinfo { get; set; }
        [XmlElement(ElementName = "action")]
        public Action Action { get; set; }
        [XmlElement(ElementName = "actionapplicationversioninfo")]
        public Actionapplicationversioninfo Actionapplicationversioninfo { get; set; }
        [XmlAttribute(AttributeName = "evaluation")]
        public string Evaluation { get; set; }
        [XmlAttribute(AttributeName = "valuetomatch")]
        public string Valuetomatch { get; set; }
        [XmlAttribute(AttributeName = "matchignorewhitespaces")]
        public string Matchignorewhitespaces { get; set; }
        [XmlAttribute(AttributeName = "taggedregex")]
        public string Taggedregex { get; set; }
        [XmlAttribute(AttributeName = "experiencezonereason")]
        public string Experiencezonereason { get; set; }
        [XmlAttribute(AttributeName = "operatingsystemdetailllevel")]
        public string Operatingsystemdetailllevel { get; set; }
        [XmlAttribute(AttributeName = "match")]
        public string Match { get; set; }
        [XmlAttribute(AttributeName = "matchcasesensitive")]
        public string Matchcasesensitive { get; set; }
        [XmlAttribute(AttributeName = "useragentdetaillevel")]
        public string Useragentdetaillevel { get; set; }
        [XmlAttribute(AttributeName = "experiencezone")]
        public string Experiencezone { get; set; }
        [XmlElement(ElementName = "sourcepagematch")]
        public Sourcepagematch Sourcepagematch { get; set; }
        [XmlElement(ElementName = "targetpagematch")]
        public Targetpagematch Targetpagematch { get; set; }
        [XmlElement(ElementName = "sourceaction")]
        public Sourceaction Sourceaction { get; set; }
        [XmlElement(ElementName = "customaction")]
        public Customaction Customaction { get; set; }
        [XmlElement(ElementName = "thirdpartydomainrule")]
        public Thirdpartydomainrule Thirdpartydomainrule { get; set; }
        [XmlElement(ElementName = "adkvaluerule")]
        public Adkvaluerule Adkvaluerule { get; set; }
        [XmlAttribute(AttributeName = "tpdurationtype")]
        public string Tpdurationtype { get; set; }
        [XmlAttribute(AttributeName = "tpdurationresource")]
        public string Tpdurationresource { get; set; }
        [XmlAttribute(AttributeName = "evaluationcriterion")]
        public string Evaluationcriterion { get; set; }
        [XmlAttribute(AttributeName = "splittingbitset")]
        public string Splittingbitset { get; set; }
        [XmlAttribute(AttributeName = "metadataid")]
        public string Metadataid { get; set; }
        [XmlAttribute(AttributeName = "tpresourcestate")]
        public string Tpresourcestate { get; set; }
        [XmlAttribute(AttributeName = "apdexzone")]
        public string Apdexzone { get; set; }
        [XmlAttribute(AttributeName = "tpdurationthreshold")]
        public string Tpdurationthreshold { get; set; }
        [XmlAttribute(AttributeName = "category")]
        public string Category { get; set; }
        [XmlElement(ElementName = "thresholds")]
        public Thresholds Thresholds { get; set; }
        [XmlAttribute(AttributeName = "endpointmatch")]
        public string Endpointmatch { get; set; }
        [XmlAttribute(AttributeName = "usedmethod")]
        public string Usedmethod { get; set; }
        [XmlAttribute(AttributeName = "operationnamematch")]
        public string Operationnamematch { get; set; }
        [XmlAttribute(AttributeName = "endpoint")]
        public string Endpoint { get; set; }
        [XmlAttribute(AttributeName = "operationname")]
        public string Operationname { get; set; }
        [XmlElement(ElementName = "geoinfo")]
        public Geoinfo Geoinfo { get; set; }
        [XmlAttribute(AttributeName = "groupmeasurement")]
        public string Groupmeasurement { get; set; }
        [XmlAttribute(AttributeName = "servletargument")]
        public string Servletargument { get; set; }
        [XmlAttribute(AttributeName = "tagging")]
        public string Tagging { get; set; }
        [XmlAttribute(AttributeName = "querymatch")]
        public string Querymatch { get; set; }
        [XmlAttribute(AttributeName = "occurrence")]
        public string Occurrence { get; set; }
        [XmlAttribute(AttributeName = "urimatch")]
        public string Urimatch { get; set; }
        [XmlAttribute(AttributeName = "referrermatch")]
        public string Referrermatch { get; set; }
        [XmlAttribute(AttributeName = "webserver")]
        public string Webserver { get; set; }
        [XmlAttribute(AttributeName = "query")]
        public string Query { get; set; }
        [XmlAttribute(AttributeName = "errorpage")]
        public string Errorpage { get; set; }
        [XmlAttribute(AttributeName = "includequery")]
        public string Includequery { get; set; }
        [XmlAttribute(AttributeName = "uri")]
        public string Uri { get; set; }
        [XmlAttribute(AttributeName = "errorpagematch")]
        public string Errorpagematch { get; set; }
        [XmlAttribute(AttributeName = "referrer")]
        public string Referrer { get; set; }
        [XmlAttribute(AttributeName = "applyhostfilter")]
        public string Applyhostfilter { get; set; }
        [XmlElement(ElementName = "com.dynatrace.diagnostics.global.processperformancemeasureconfig")]
        public string Processperformancemeasureconfig { get; set; }
        [XmlAttribute(AttributeName = "loggingnamematch")]
        public string Loggingnamematch { get; set; }
        [XmlAttribute(AttributeName = "logginglevel")]
        public string Logginglevel { get; set; }
        [XmlAttribute(AttributeName = "loggingname")]
        public string Loggingname { get; set; }
        [XmlAttribute(AttributeName = "loggingmessage")]
        public string Loggingmessage { get; set; }
        [XmlAttribute(AttributeName = "logginglevelmatch")]
        public string Logginglevelmatch { get; set; }
        [XmlAttribute(AttributeName = "loggingmessagematch")]
        public string Loggingmessagematch { get; set; }
        [XmlAttribute(AttributeName = "throwableclassmath")]
        public string Throwableclassmath { get; set; }
        [XmlAttribute(AttributeName = "messagematch")]
        public string Messagematch { get; set; }
        [XmlAttribute(AttributeName = "message")]
        public string Message { get; set; }
        [XmlAttribute(AttributeName = "throwableclass")]
        public string Throwableclass { get; set; }
        [XmlAttribute(AttributeName = "exceptiontype")]
        public string Exceptiontype { get; set; }
        [XmlAttribute(AttributeName = "techtype")]
        public string Techtype { get; set; }
        [XmlElement(ElementName = "pagematcher")]
        public Pagematcher Pagematcher { get; set; }
        [XmlAttribute(AttributeName = "actionnamematch")]
        public string Actionnamematch { get; set; }
        [XmlAttribute(AttributeName = "actiontype")]
        public string Actiontype { get; set; }
        [XmlAttribute(AttributeName = "actiontypematch")]
        public string Actiontypematch { get; set; }
        [XmlAttribute(AttributeName = "info")]
        public string Info { get; set; }
        [XmlAttribute(AttributeName = "severity")]
        public string Severity { get; set; }
        [XmlAttribute(AttributeName = "actionname")]
        public string _Actionname { get; set; }
        [XmlElement(ElementName = "actionname")]
        public Actionname Actionname { get; set; }
        [XmlAttribute(AttributeName = "infomatch")]
        public string Infomatch { get; set; }
        [XmlAttribute(AttributeName = "sql")]
        public string Sql { get; set; }
        [XmlAttribute(AttributeName = "sqlmatch")]
        public string Sqlmatch { get; set; }
        [XmlAttribute(AttributeName = "apimatch")]
        public string Apimatch { get; set; }
        [XmlAttribute(AttributeName = "api")]
        public string Api { get; set; }
        [XmlAttribute(AttributeName = "appversioncomp")]
        public string Appversioncomp { get; set; }
        [XmlAttribute(AttributeName = "errornamematch")]
        public string Errornamematch { get; set; }
        [XmlAttribute(AttributeName = "messagetextmatch")]
        public string Messagetextmatch { get; set; }
        [XmlAttribute(AttributeName = "errorcodevaluecomp")]
        public string Errorcodevaluecomp { get; set; }
        [XmlAttribute(AttributeName = "errorname")]
        public string Errorname { get; set; }
        [XmlAttribute(AttributeName = "mobileerrortype")]
        public string Mobileerrortype { get; set; }
        [XmlAttribute(AttributeName = "appversion")]
        public string Appversion { get; set; }
        [XmlAttribute(AttributeName = "appshortversioncomp")]
        public string Appshortversioncomp { get; set; }
        [XmlAttribute(AttributeName = "messagetext")]
        public string Messagetext { get; set; }
        [XmlAttribute(AttributeName = "errorcodevalue")]
        public string Errorcodevalue { get; set; }
        [XmlAttribute(AttributeName = "appshortversion")]
        public string Appshortversion { get; set; }
        [XmlAttribute(AttributeName = "countonlyrootactions")]
        public string Countonlyrootactions { get; set; }
        [XmlAttribute(AttributeName = "transformationregex")]
        public string Transformationregex { get; set; }
        [XmlAttribute(AttributeName = "pathmatcher")]
        public string Pathmatcher { get; set; }
        [XmlAttribute(AttributeName = "path")]
        public string Path { get; set; }
        [XmlAttribute(AttributeName = "errormessage")]
        public string Errormessage { get; set; }
        [XmlAttribute(AttributeName = "throwingmethod")]
        public string Throwingmethod { get; set; }
        [XmlAttribute(AttributeName = "exceptionclassmatcher")]
        public string Exceptionclassmatcher { get; set; }
        [XmlAttribute(AttributeName = "throwingclass")]
        public string Throwingclass { get; set; }
        [XmlAttribute(AttributeName = "exceptionclass")]
        public string Exceptionclass { get; set; }
        [XmlAttribute(AttributeName = "errormessagematcher")]
        public string Errormessagematcher { get; set; }
        [XmlAttribute(AttributeName = "errortypematcher")]
        public string Errortypematcher { get; set; }
        [XmlAttribute(AttributeName = "throwingmethodmatcher")]
        public string Throwingmethodmatcher { get; set; }
        [XmlAttribute(AttributeName = "throwingclassmatcher")]
        public string Throwingclassmatcher { get; set; }
        [XmlAttribute(AttributeName = "thresholdseverity")]
        public string Thresholdseverity { get; set; }
        [XmlElement(ElementName = "sourcemeasure")]
        public Sourcemeasure Sourcemeasure { get; set; }
        [XmlAttribute(AttributeName = "aggregategroups")]
        public string Aggregategroups { get; set; }
        [XmlAttribute(AttributeName = "transactionname")]
        public string Transactionname { get; set; }
        [XmlAttribute(AttributeName = "isnumerical")]
        public string Isnumerical { get; set; }
        [XmlElement(ElementName = "configuration")]
        public Configuration Configuration { get; set; }
    }

    [XmlRoot(ElementName = "actiongeoinfo")]
    public class Actiongeoinfo
    {
        [XmlAttribute(AttributeName = "measuredetaillevel")]
        public string Measuredetaillevel { get; set; }
        [XmlElement(ElementName = "customrules")]
        public Customrules Customrules { get; set; }
    }

    [XmlRoot(ElementName = "actionname")]
    public class Actionname
    {
        [XmlAttribute(AttributeName = "pattern")]
        public string Pattern { get; set; }
        [XmlAttribute(AttributeName = "match")]
        public string Match { get; set; }
    }

    [XmlRoot(ElementName = "actiontype")]
    public class Actiontype
    {
        [XmlAttribute(AttributeName = "pattern")]
        public string Pattern { get; set; }
        [XmlAttribute(AttributeName = "match")]
        public string Match { get; set; }
    }

    [XmlRoot(ElementName = "action")]
    public class Action
    {
        [XmlElement(ElementName = "actionname")]
        public Actionname Actionname { get; set; }
        [XmlElement(ElementName = "actiontype")]
        public Actiontype Actiontype { get; set; }
    }

    [XmlRoot(ElementName = "actionapplicationversioninfo")]
    public class Actionapplicationversioninfo
    {
        [XmlAttribute(AttributeName = "appbuildversioncompare")]
        public string Appbuildversioncompare { get; set; }
        [XmlAttribute(AttributeName = "appbuildversionpattern")]
        public string Appbuildversionpattern { get; set; }
        [XmlAttribute(AttributeName = "appversioncompare")]
        public string Appversioncompare { get; set; }
        [XmlAttribute(AttributeName = "actionselectedapptype")]
        public string Actionselectedapptype { get; set; }
        [XmlAttribute(AttributeName = "appversionpattern")]
        public string Appversionpattern { get; set; }
    }

    [XmlRoot(ElementName = "pagetitle")]
    public class Pagetitle
    {
        [XmlAttribute(AttributeName = "pattern")]
        public string Pattern { get; set; }
        [XmlAttribute(AttributeName = "match")]
        public string Match { get; set; }
    }

    [XmlRoot(ElementName = "uri")]
    public class Uri
    {
        [XmlAttribute(AttributeName = "pattern")]
        public string Pattern { get; set; }
        [XmlAttribute(AttributeName = "match")]
        public string Match { get; set; }
    }

    [XmlRoot(ElementName = "query")]
    public class Query
    {
        [XmlAttribute(AttributeName = "pattern")]
        public string Pattern { get; set; }
        [XmlAttribute(AttributeName = "match")]
        public string Match { get; set; }
    }

    [XmlRoot(ElementName = "sourcepagematch")]
    public class Sourcepagematch
    {
        [XmlElement(ElementName = "pagetitle")]
        public Pagetitle Pagetitle { get; set; }
        [XmlElement(ElementName = "uri")]
        public Uri Uri { get; set; }
        [XmlElement(ElementName = "query")]
        public Query Query { get; set; }
    }

    [XmlRoot(ElementName = "targetpagematch")]
    public class Targetpagematch
    {
        [XmlElement(ElementName = "pagetitle")]
        public Pagetitle Pagetitle { get; set; }
        [XmlElement(ElementName = "uri")]
        public Uri Uri { get; set; }
        [XmlElement(ElementName = "query")]
        public Query Query { get; set; }
    }

    [XmlRoot(ElementName = "sourceaction")]
    public class Sourceaction
    {
        [XmlElement(ElementName = "actionname")]
        public Actionname Actionname { get; set; }
        [XmlElement(ElementName = "actiontype")]
        public Actiontype Actiontype { get; set; }
    }

    [XmlRoot(ElementName = "customaction")]
    public class Customaction
    {
        [XmlElement(ElementName = "actionname")]
        public Actionname Actionname { get; set; }
        [XmlElement(ElementName = "actiontype")]
        public Actiontype Actiontype { get; set; }
    }

    [XmlRoot(ElementName = "thirdpartydomainrule")]
    public class Thirdpartydomainrule
    {
        [XmlAttribute(AttributeName = "pattern")]
        public string Pattern { get; set; }
        [XmlAttribute(AttributeName = "match")]
        public string Match { get; set; }
    }

    [XmlRoot(ElementName = "adkvaluerule")]
    public class Adkvaluerule
    {
        [XmlAttribute(AttributeName = "pattern")]
        public string Pattern { get; set; }
        [XmlAttribute(AttributeName = "match")]
        public string Match { get; set; }
    }

    [XmlRoot(ElementName = "thresholds")]
    public class Thresholds
    {
        [XmlAttribute(AttributeName = "threshold.upper.severe")]
        public string ThresholdUpperSevere { get; set; }
        [XmlAttribute(AttributeName = "threshold.lower.severe")]
        public string ThresholdLowerSevere { get; set; }
    }

    [XmlRoot(ElementName = "geoinfo")]
    public class Geoinfo
    {
        [XmlAttribute(AttributeName = "measuredetaillevel")]
        public string Measuredetaillevel { get; set; }
    }

    [XmlRoot(ElementName = "pagematcher")]
    public class Pagematcher
    {
        [XmlElement(ElementName = "pagetitle")]
        public Pagetitle Pagetitle { get; set; }
        [XmlElement(ElementName = "uri")]
        public Uri Uri { get; set; }
        [XmlElement(ElementName = "query")]
        public Query Query { get; set; }
    }

    [XmlRoot(ElementName = "rule")]
    public class Rule
    {
        [XmlAttribute(AttributeName = "ruledetaillevel")]
        public string Ruledetaillevel { get; set; }
        [XmlAttribute(AttributeName = "rulekey")]
        public string Rulekey { get; set; }
    }

    [XmlRoot(ElementName = "customrules")]
    public class Customrules
    {
        [XmlElement(ElementName = "rule")]
        public Rule Rule { get; set; }
    }

    [XmlRoot(ElementName = "sourcemeasure")]
    public class Sourcemeasure
    {
        [XmlElement(ElementName = "measure")]
        public Measure Measure { get; set; }
    }

    [XmlRoot(ElementName = "measures")]
    public class Measures
    {
        [XmlElement(ElementName = "measure")]
        public List<Measure> Measure { get; set; }
    }

    [XmlRoot(ElementName = "trigger")]
    public class Trigger
    {
        [XmlAttribute(AttributeName = "endmode")]
        public string Endmode { get; set; }
        [XmlAttribute(AttributeName = "include")]
        public string Include { get; set; }
        [XmlAttribute(AttributeName = "repeat")]
        public string Repeat { get; set; }
        [XmlAttribute(AttributeName = "interval")]
        public string Interval { get; set; }
        [XmlAttribute(AttributeName = "end")]
        public string End { get; set; }
        [XmlAttribute(AttributeName = "recurrmode")]
        public string Recurrmode { get; set; }
        [XmlAttribute(AttributeName = "begin")]
        public string Begin { get; set; }
        [XmlElement(ElementName = "calendar")]
        public List<Calendar> Calendar { get; set; }
    }

    [XmlRoot(ElementName = "schedule")]
    public class Schedule
    {
        [XmlElement(ElementName = "trigger")]
        public Trigger Trigger { get; set; }
        [XmlAttribute(AttributeName = "timezone")]
        public string Timezone { get; set; }
        [XmlAttribute(AttributeName = "useservertimezone")]
        public string Useservertimezone { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "calendar")]
    public class Calendar
    {
        [XmlAttribute(AttributeName = "exclude")]
        public string Exclude { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "schedules")]
    public class Schedules
    {
        [XmlElement(ElementName = "schedule")]
        public List<Schedule> Schedule { get; set; }
        [XmlAttribute(AttributeName = "rev")]
        public string Rev { get; set; }
    }

    [XmlRoot(ElementName = "tasks")]
    public class Tasks
    {
        [XmlAttribute(AttributeName = "rev")]
        public string Rev { get; set; }
    }

    [XmlRoot(ElementName = "monitors")]
    public class Monitors
    {
        [XmlAttribute(AttributeName = "rev")]
        public string Rev { get; set; }
    }

    [XmlRoot(ElementName = "configuration")]
    public class Configuration
    {
        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "active")]
        public string Active { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "subscribed")]
        public string Subscribed { get; set; }
        [XmlElement(ElementName = "item")]
        public List<Item> Item { get; set; }
    }

    [XmlRoot(ElementName = "configurations")]
    public class Configurations
    {
        [XmlElement(ElementName = "configuration")]
        public Configuration Configuration { get; set; }
    }

    [XmlRoot(ElementName = "actiongroupconfig")]
    public class Actiongroupconfig
    {
        [XmlElement(ElementName = "actiongroup_criteria_group")]
        public string Actiongroup_criteria_group { get; set; }
        [XmlAttribute(AttributeName = "actiongroup_description")]
        public string Actiongroup_description { get; set; }
        [XmlAttribute(AttributeName = "actiongroup_threshold")]
        public string Actiongroup_threshold { get; set; }
        [XmlAttribute(AttributeName = "actiongroup_name")]
        public string Actiongroup_name { get; set; }
        [XmlAttribute(AttributeName = "actiongroup_type")]
        public string Actiongroup_type { get; set; }
        [XmlAttribute(AttributeName = "actiongroup_default")]
        public string Actiongroup_default { get; set; }
    }

    [XmlRoot(ElementName = "actiongroup")]
    public class Actiongroup
    {
        [XmlElement(ElementName = "actiongroupconfig")]
        public List<Actiongroupconfig> Actiongroupconfig { get; set; }
    }

    [XmlRoot(ElementName = "iprangerulelist")]
    public class Iprangerulelist
    {
        [XmlElement(ElementName = "rules")]
        public string Rules { get; set; }
        [XmlAttribute(AttributeName = "includeall")]
        public string Includeall { get; set; }
    }

    [XmlRoot(ElementName = "browserrulelist")]
    public class Browserrulelist
    {
        [XmlElement(ElementName = "rules")]
        public string Rules { get; set; }
        [XmlAttribute(AttributeName = "includeall")]
        public string Includeall { get; set; }
    }

    [XmlRoot(ElementName = "module")]
    public class Module
    {
        [XmlAttribute(AttributeName = "featurehash")]
        public string Featurehash { get; set; }
        [XmlAttribute(AttributeName = "hint")]
        public string Hint { get; set; }
        [XmlAttribute(AttributeName = "active")]
        public string Active { get; set; }
        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }
    }

    [XmlRoot(ElementName = "modules")]
    public class Modules
    {
        [XmlElement(ElementName = "module")]
        public List<Module> Module { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "jsagentoption")]
    public class Jsagentoption
    {
        [XmlElement(ElementName = "modules")]
        public Modules Modules { get; set; }
        [XmlAttribute(AttributeName = "agentoption")]
        public string Agentoption { get; set; }
    }

    [XmlRoot(ElementName = "mobileoptions")]
    public class Mobileoptions
    {
        [XmlAttribute(AttributeName = "captureerrors")]
        public string Captureerrors { get; set; }
        [XmlAttribute(AttributeName = "maxmobilecrashreportsperminute")]
        public string Maxmobilecrashreportsperminute { get; set; }
        [XmlAttribute(AttributeName = "capturelifecycle")]
        public string Capturelifecycle { get; set; }
        [XmlAttribute(AttributeName = "capturecrashes")]
        public string Capturecrashes { get; set; }
    }

    [XmlRoot(ElementName = "uemsensorconfig")]
    public class Uemsensorconfig
    {
        [XmlElement(ElementName = "iprangerulelist")]
        public Iprangerulelist Iprangerulelist { get; set; }
        [XmlElement(ElementName = "browserrulelist")]
        public Browserrulelist Browserrulelist { get; set; }
        [XmlElement(ElementName = "jsagentoption")]
        public Jsagentoption Jsagentoption { get; set; }
        [XmlElement(ElementName = "mobileoptions")]
        public Mobileoptions Mobileoptions { get; set; }
        [XmlElement(ElementName = "metadata")]
        public string Metadata { get; set; }
        [XmlAttribute(AttributeName = "agentpath")]
        public string Agentpath { get; set; }
        [XmlAttribute(AttributeName = "debug")]
        public string Debug { get; set; }
        [XmlAttribute(AttributeName = "visitpercentageblocksserverside")]
        public string Visitpercentageblocksserverside { get; set; }
        [XmlAttribute(AttributeName = "injectionpercentage")]
        public string Injectionpercentage { get; set; }
        [XmlAttribute(AttributeName = "uemmode")]
        public string Uemmode { get; set; }
        [XmlAttribute(AttributeName = "domain")]
        public string Domain { get; set; }
        [XmlAttribute(AttributeName = "debugagentpath")]
        public string Debugagentpath { get; set; }
        [XmlAttribute(AttributeName = "appversion")]
        public string Appversion { get; set; }
        [XmlAttribute(AttributeName = "mobileactionsenddelayinseconds")]
        public string Mobileactionsenddelayinseconds { get; set; }
        [XmlAttribute(AttributeName = "monitorrequestpath")]
        public string Monitorrequestpath { get; set; }
        [XmlAttribute(AttributeName = "securestatecookie")]
        public string Securestatecookie { get; set; }
    }

    [XmlRoot(ElementName = "visitexperiencezoneconfig")]
    public class Visitexperiencezoneconfig
    {
        [XmlAttribute(AttributeName = "satisfied_minimum")]
        public string Satisfied_minimum { get; set; }
        [XmlAttribute(AttributeName = "frustrated_maximum")]
        public string Frustrated_maximum { get; set; }
    }

    [XmlRoot(ElementName = "jsagentversion")]
    public class Jsagentversion
    {
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "availablejsagentversions")]
    public class Availablejsagentversions
    {
        [XmlElement(ElementName = "jsagentversion")]
        public List<Jsagentversion> Jsagentversion { get; set; }
        [XmlAttribute(AttributeName = "uselatestjsagentversion")]
        public string Uselatestjsagentversion { get; set; }
        [XmlAttribute(AttributeName = "activejsagentversion")]
        public string Activejsagentversion { get; set; }
    }

    [XmlRoot(ElementName = "topfindingsconfig")]
    public class Topfindingsconfig
    {
        [XmlAttribute(AttributeName = "high_cdn_contribution")]
        public string High_cdn_contribution { get; set; }
        [XmlAttribute(AttributeName = "high_network_contribution")]
        public string High_network_contribution { get; set; }
        [XmlAttribute(AttributeName = "high_first_party_contribution")]
        public string High_first_party_contribution { get; set; }
        [XmlAttribute(AttributeName = "high_server_contribution")]
        public string High_server_contribution { get; set; }
        [XmlAttribute(AttributeName = "high_third_party_contribution")]
        public string High_third_party_contribution { get; set; }
    }

    [XmlRoot(ElementName = "uemappconfig")]
    public class Uemappconfig
    {
        [XmlElement(ElementName = "actiongroup")]
        public Actiongroup Actiongroup { get; set; }
        [XmlElement(ElementName = "uemsensorconfig")]
        public Uemsensorconfig Uemsensorconfig { get; set; }
        [XmlElement(ElementName = "visitexperiencezoneconfig")]
        public Visitexperiencezoneconfig Visitexperiencezoneconfig { get; set; }
        [XmlElement(ElementName = "availablejsagentversions")]
        public Availablejsagentversions Availablejsagentversions { get; set; }
        [XmlElement(ElementName = "topfindingsconfig")]
        public Topfindingsconfig Topfindingsconfig { get; set; }
        [XmlAttribute(AttributeName = "visittimeout")]
        public string Visittimeout { get; set; }
        [XmlAttribute(AttributeName = "injectionstrategy")]
        public string Injectionstrategy { get; set; }
        [XmlAttribute(AttributeName = "visittimeoutunit")]
        public string Visittimeoutunit { get; set; }
    }

    [XmlRoot(ElementName = "webservicetag")]
    public class Webservicetag
    {
        [XmlAttribute(AttributeName = "samewebservicecallcount")]
        public string Samewebservicecallcount { get; set; }
        [XmlAttribute(AttributeName = "totalcallcount")]
        public string Totalcallcount { get; set; }
        [XmlAttribute(AttributeName = "singlewebservicetimethreshold")]
        public string Singlewebservicetimethreshold { get; set; }
        [XmlAttribute(AttributeName = "hightimethreshold")]
        public string Hightimethreshold { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "slowtriggertimetreshold")]
        public string Slowtriggertimetreshold { get; set; }
        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "requestresponsesize")]
        public string Requestresponsesize { get; set; }
        [XmlAttribute(AttributeName = "pathtagposition")]
        public string Pathtagposition { get; set; }
    }

    [XmlRoot(ElementName = "webservicecategory")]
    public class Webservicecategory
    {
        [XmlElement(ElementName = "webservicetag")]
        public List<Webservicetag> Webservicetag { get; set; }
        [XmlAttribute(AttributeName = "enabled")]
        public string Enabled { get; set; }
    }

    [XmlRoot(ElementName = "sizetag")]
    public class Sizetag
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "minsize")]
        public string Minsize { get; set; }
        [XmlAttribute(AttributeName = "pathtagposition")]
        public string Pathtagposition { get; set; }
    }

    [XmlRoot(ElementName = "sizecategory")]
    public class Sizecategory
    {
        [XmlElement(ElementName = "sizetag")]
        public List<Sizetag> Sizetag { get; set; }
        [XmlAttribute(AttributeName = "enabled")]
        public string Enabled { get; set; }
    }

    [XmlRoot(ElementName = "threadingtag")]
    public class Threadingtag
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "pathtagposition")]
        public string Pathtagposition { get; set; }
        [XmlAttribute(AttributeName = "minthreads")]
        public string Minthreads { get; set; }
    }

    [XmlRoot(ElementName = "threadingcategory")]
    public class Threadingcategory
    {
        [XmlElement(ElementName = "threadingtag")]
        public List<Threadingtag> Threadingtag { get; set; }
        [XmlAttribute(AttributeName = "enabled")]
        public string Enabled { get; set; }
    }

    [XmlRoot(ElementName = "asynctag")]
    public class Asynctag
    {
        [XmlAttribute(AttributeName = "minasynctoresponsetimeratio")]
        public string Minasynctoresponsetimeratio { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "pathtagposition")]
        public string Pathtagposition { get; set; }
    }

    [XmlRoot(ElementName = "asynccategory")]
    public class Asynccategory
    {
        [XmlElement(ElementName = "asynctag")]
        public List<Asynctag> Asynctag { get; set; }
        [XmlAttribute(AttributeName = "enabled")]
        public string Enabled { get; set; }
    }

    [XmlRoot(ElementName = "httptag")]
    public class Httptag
    {
        [XmlAttribute(AttributeName = "httpcodemin")]
        public string Httpcodemin { get; set; }
        [XmlAttribute(AttributeName = "httpcodemax")]
        public string Httpcodemax { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "pathtagposition")]
        public string Pathtagposition { get; set; }
    }

    [XmlRoot(ElementName = "httpcodecategory")]
    public class Httpcodecategory
    {
        [XmlElement(ElementName = "httptag")]
        public List<Httptag> Httptag { get; set; }
        [XmlAttribute(AttributeName = "enabled")]
        public string Enabled { get; set; }
    }

    [XmlRoot(ElementName = "responsetimetag")]
    public class Responsetimetag
    {
        [XmlAttribute(AttributeName = "mintime")]
        public string Mintime { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "pathtagposition")]
        public string Pathtagposition { get; set; }
    }

    [XmlRoot(ElementName = "responsetimecategory")]
    public class Responsetimecategory
    {
        [XmlElement(ElementName = "responsetimetag")]
        public List<Responsetimetag> Responsetimetag { get; set; }
        [XmlAttribute(AttributeName = "enabled")]
        public string Enabled { get; set; }
    }

    [XmlRoot(ElementName = "dbrelatedtag")]
    public class Dbrelatedtag
    {
        [XmlAttribute(AttributeName = "singletimethreshold")]
        public string Singletimethreshold { get; set; }
        [XmlAttribute(AttributeName = "totalexeccountthreshold")]
        public string Totalexeccountthreshold { get; set; }
        [XmlAttribute(AttributeName = "singleexeccountthreshold")]
        public string Singleexeccountthreshold { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "pathtagposition")]
        public string Pathtagposition { get; set; }
        [XmlAttribute(AttributeName = "totaltimethreshold")]
        public string Totaltimethreshold { get; set; }
    }

    [XmlRoot(ElementName = "dbrelatedcategory")]
    public class Dbrelatedcategory
    {
        [XmlElement(ElementName = "dbrelatedtag")]
        public List<Dbrelatedtag> Dbrelatedtag { get; set; }
        [XmlAttribute(AttributeName = "enabled")]
        public string Enabled { get; set; }
    }

    [XmlRoot(ElementName = "complexitytag")]
    public class Complexitytag
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "minnodes")]
        public string Minnodes { get; set; }
        [XmlAttribute(AttributeName = "pathtagposition")]
        public string Pathtagposition { get; set; }
        [XmlAttribute(AttributeName = "minagents")]
        public string Minagents { get; set; }
    }

    [XmlRoot(ElementName = "complexitycategory")]
    public class Complexitycategory
    {
        [XmlElement(ElementName = "complexitytag")]
        public List<Complexitytag> Complexitytag { get; set; }
        [XmlAttribute(AttributeName = "enabled")]
        public string Enabled { get; set; }
    }

    [XmlRoot(ElementName = "defaultpathcategorizationconfig")]
    public class Defaultpathcategorizationconfig
    {
        [XmlElement(ElementName = "webservicecategory")]
        public Webservicecategory Webservicecategory { get; set; }
        [XmlElement(ElementName = "sizecategory")]
        public Sizecategory Sizecategory { get; set; }
        [XmlElement(ElementName = "threadingcategory")]
        public Threadingcategory Threadingcategory { get; set; }
        [XmlElement(ElementName = "asynccategory")]
        public Asynccategory Asynccategory { get; set; }
        [XmlElement(ElementName = "httpcodecategory")]
        public Httpcodecategory Httpcodecategory { get; set; }
        [XmlElement(ElementName = "responsetimecategory")]
        public Responsetimecategory Responsetimecategory { get; set; }
        [XmlElement(ElementName = "dbrelatedcategory")]
        public Dbrelatedcategory Dbrelatedcategory { get; set; }
        [XmlElement(ElementName = "complexitycategory")]
        public Complexitycategory Complexitycategory { get; set; }
        [XmlAttribute(AttributeName = "enabled")]
        public string Enabled { get; set; }
    }

    [XmlRoot(ElementName = "uemhealthcheckconfig")]
    public class Uemhealthcheckconfig
    {
        [XmlElement(ElementName = "uemapplicationhealthcheckconfigs")]
        public string Uemapplicationhealthcheckconfigs { get; set; }
    }

    [XmlRoot(ElementName = "uemdomain")]
    public class Uemdomain
    {
        [XmlAttribute(AttributeName = "domain")]
        public string Domain { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "uemdomainthirdparty")]
    public class Uemdomainthirdparty
    {
        [XmlElement(ElementName = "uemdomain")]
        public List<Uemdomain> Uemdomain { get; set; }
    }

    [XmlRoot(ElementName = "uemdomainconfig")]
    public class Uemdomainconfig
    {
        [XmlElement(ElementName = "uemdomainthirdparty")]
        public Uemdomainthirdparty Uemdomainthirdparty { get; set; }
    }

    [XmlRoot(ElementName = "uemconfiguration")]
    public class Uemconfiguration
    {
        [XmlElement(ElementName = "uemappconfig")]
        public Uemappconfig Uemappconfig { get; set; }
        [XmlElement(ElementName = "defaultpathcategorizationconfig")]
        public Defaultpathcategorizationconfig Defaultpathcategorizationconfig { get; set; }
        [XmlElement(ElementName = "applications")]
        public string Applications { get; set; }
        [XmlElement(ElementName = "uemhealthcheckconfig")]
        public Uemhealthcheckconfig Uemhealthcheckconfig { get; set; }
        [XmlElement(ElementName = "uemdomainconfig")]
        public Uemdomainconfig Uemdomainconfig { get; set; }
        [XmlAttribute(AttributeName = "monitorrequestname")]
        public string Monitorrequestname { get; set; }
        [XmlAttribute(AttributeName = "categorizationenabled")]
        public string Categorizationenabled { get; set; }
        [XmlAttribute(AttributeName = "autodetecttype")]
        public string Autodetecttype { get; set; }
        [XmlAttribute(AttributeName = "javascriptagentname")]
        public string Javascriptagentname { get; set; }
    }

    [XmlRoot(ElementName = "dataprivacyconfiguration")]
    public class Dataprivacyconfiguration
    {
        [XmlAttribute(AttributeName = "ipmasking")]
        public string Ipmasking { get; set; }
        [XmlAttribute(AttributeName = "donottrack")]
        public string Donottrack { get; set; }
        [XmlAttribute(AttributeName = "useractionmasking")]
        public string Useractionmasking { get; set; }
    }

    [XmlRoot(ElementName = "dcrumconfig")]
    public class Dcrumconfig
    {
        [XmlAttribute(AttributeName = "active")]
        public string Active { get; set; }
    }

    [XmlRoot(ElementName = "casuemdataexport")]
    public class Casuemdataexport
    {
        [XmlAttribute(AttributeName = "storagebytelimit")]
        public string Storagebytelimit { get; set; }
        [XmlAttribute(AttributeName = "enabled")]
        public string Enabled { get; set; }
    }

    [XmlRoot(ElementName = "property")]
    public class Property
    {
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }
        [XmlAttribute(AttributeName = "typeid")]
        public string Typeid { get; set; }
    }

    [XmlRoot(ElementName = "genericagentproperties")]
    public class Genericagentproperties
    {
        [XmlElement(ElementName = "property")]
        public List<Property> Property { get; set; }
    }

    [XmlRoot(ElementName = "value")]
    public class Value
    {
        [XmlElement(ElementName = "measure")]
        public List<Measure> Measure { get; set; }
    }

    [XmlRoot(ElementName = "measureref")]
    public class Measureref
    {
        [XmlAttribute(AttributeName = "logicaloperator")]
        public string Logicaloperator { get; set; }
        [XmlAttribute(AttributeName = "refmeasure")]
        public string Refmeasure { get; set; }
        [XmlAttribute(AttributeName = "refmetricgroup")]
        public string Refmetricgroup { get; set; }
        [XmlAttribute(AttributeName = "refmetric")]
        public string Refmetric { get; set; }
        [XmlAttribute(AttributeName = "aggregate")]
        public string Aggregate { get; set; }
    }

    [XmlRoot(ElementName = "filter")]
    public class Filter
    {
        [XmlElement(ElementName = "measureref")]
        public List<Measureref> Measureref { get; set; }
    }

    [XmlRoot(ElementName = "group")]
    public class Group
    {
        [XmlElement(ElementName = "measureref")]
        public List<Measureref> Measureref { get; set; }
    }

    [XmlRoot(ElementName = "evaluate")]
    public class Evaluate
    {
        [XmlElement(ElementName = "measureref")]
        public List<Measureref> Measureref { get; set; }
    }

    [XmlRoot(ElementName = "transaction")]
    public class Transaction
    {
        [XmlElement(ElementName = "value")]
        public Value Value { get; set; }
        [XmlElement(ElementName = "filter")]
        public Filter Filter { get; set; }
        [XmlElement(ElementName = "group")]
        public Group Group { get; set; }
        [XmlElement(ElementName = "evaluate")]
        public Evaluate Evaluate { get; set; }
        [XmlAttribute(AttributeName = "maxsplittings")]
        public string Maxsplittings { get; set; }
        [XmlAttribute(AttributeName = "subscriptiontype")]
        public string Subscriptiontype { get; set; }
        [XmlAttribute(AttributeName = "servicecontext")]
        public string Servicecontext { get; set; }
        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "errordetectionsupport")]
        public string Errordetectionsupport { get; set; }
        [XmlAttribute(AttributeName = "exportincludeperfdata")]
        public string Exportincludeperfdata { get; set; }
        [XmlAttribute(AttributeName = "enabled")]
        public string Enabled { get; set; }
        [XmlAttribute(AttributeName = "transactiontype")]
        public string Transactiontype { get; set; }
        [XmlAttribute(AttributeName = "aggregategroups")]
        public string Aggregategroups { get; set; }
        [XmlAttribute(AttributeName = "mode")]
        public string Mode { get; set; }
        [XmlAttribute(AttributeName = "errortransactiontype")]
        public string Errortransactiontype { get; set; }
        [XmlAttribute(AttributeName = "minpercentage")]
        public string Minpercentage { get; set; }
        [XmlAttribute(AttributeName = "exportincludesessionref")]
        public string Exportincludesessionref { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "export")]
        public string Export { get; set; }
    }

    /*[XmlRoot(ElementName = "transactions")]
    public class Transactions
    {
        [XmlElement(ElementName = "transaction")]
        public List<Transaction> Transaction { get; set; }
        [XmlAttribute(AttributeName = "rev")]
        public string Rev { get; set; }
    }*/

    [XmlRoot(ElementName = "sensitivity")]
    public class Sensitivity
    {
        [XmlAttribute(AttributeName = "duration")]
        public string Duration { get; set; }
        [XmlAttribute(AttributeName = "delay")]
        public string Delay { get; set; }
        [XmlAttribute(AttributeName = "minnonviolatedperiod")]
        public string Minnonviolatedperiod { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "actionref")]
    public class Actionref
    {
        [XmlAttribute(AttributeName = "severity")]
        public string Severity { get; set; }
        [XmlAttribute(AttributeName = "execution")]
        public string Execution { get; set; }
        [XmlAttribute(AttributeName = "smartalert")]
        public string Smartalert { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "bundleversion")]
        public string Bundleversion { get; set; }
        [XmlAttribute(AttributeName = "refaction")]
        public string Refaction { get; set; }
        [XmlAttribute(AttributeName = "rolekey")]
        public string Rolekey { get; set; }
        [XmlAttribute(AttributeName = "roletype")]
        public string Roletype { get; set; }
        [XmlAttribute(AttributeName = "smartexecution")]
        public string Smartexecution { get; set; }
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }
        [XmlElement(ElementName = "property")]
        public List<Property> Property { get; set; }
        [XmlAttribute(AttributeName = "sourcebundlename")]
        public string Sourcebundlename { get; set; }
        [XmlAttribute(AttributeName = "rolesourcebundlename")]
        public string Rolesourcebundlename { get; set; }
        [XmlAttribute(AttributeName = "user")]
        public string User { get; set; }
    }

    [XmlRoot(ElementName = "actions")]
    public class Actions
    {
        [XmlElement(ElementName = "actionref")]
        public List<Actionref> Actionref { get; set; }
    }

    [XmlRoot(ElementName = "incidentrule")]
    public class Incidentrule
    {
        [XmlElement(ElementName = "sensitivity")]
        public Sensitivity Sensitivity { get; set; }
        [XmlElement(ElementName = "actions")]
        public Actions Actions { get; set; }
        [XmlAttribute(AttributeName = "incidentdashboardname")]
        public string Incidentdashboardname { get; set; }
        [XmlAttribute(AttributeName = "timeframe")]
        public string Timeframe { get; set; }
        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }
        [XmlAttribute(AttributeName = "flags")]
        public string Flags { get; set; }
        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "conditions")]
        public Conditions Conditions { get; set; }
    }

    [XmlRoot(ElementName = "condition")]
    public class Condition
    {
        [XmlAttribute(AttributeName = "logicaloperator")]
        public string Logicaloperator { get; set; }
        [XmlAttribute(AttributeName = "refmeasure")]
        public string Refmeasure { get; set; }
        [XmlAttribute(AttributeName = "refmetricgroup")]
        public string Refmetricgroup { get; set; }
        [XmlAttribute(AttributeName = "refmetric")]
        public string Refmetric { get; set; }
        [XmlAttribute(AttributeName = "thresholdseverity")]
        public string Thresholdseverity { get; set; }
        [XmlAttribute(AttributeName = "aggregate")]
        public string Aggregate { get; set; }
        [XmlAttribute(AttributeName = "refagent")]
        public string Refagent { get; set; }
    }

    [XmlRoot(ElementName = "conditions")]
    public class Conditions
    {
        [XmlElement(ElementName = "condition")]
        public List<Condition> Condition { get; set; }
    }

    [XmlRoot(ElementName = "incidentrules")]
    public class Incidentrules
    {
        [XmlElement(ElementName = "incidentrule")]
        public List<Incidentrule> Incidentrule { get; set; }
        [XmlAttribute(AttributeName = "rev")]
        public string Rev { get; set; }
    }

    [XmlRoot(ElementName = "hostterm")]
    public class Hostterm
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "parthostexpr")]
    public class Parthostexpr
    {
        [XmlElement(ElementName = "hostterm")]
        public Hostterm Hostterm { get; set; }
    }

    [XmlRoot(ElementName = "hostexpr")]
    public class Hostexpr
    {
        [XmlElement(ElementName = "parthostexpr")]
        public List<Parthostexpr> Parthostexpr { get; set; }
    }

    [XmlRoot(ElementName = "targetterm")]
    public class Targetterm
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "targetexpr")]
    public class Targetexpr
    {
        [XmlElement(ElementName = "targetterm")]
        public Targetterm Targetterm { get; set; }
    }

    [XmlRoot(ElementName = "config")]
    public class Config
    {
        [XmlElement(ElementName = "property")]
        public List<Property> Property { get; set; }
        [XmlAttribute(AttributeName = "sourcebundlename")]
        public string Sourcebundlename { get; set; }
        [XmlAttribute(AttributeName = "rolekey")]
        public string Rolekey { get; set; }
        [XmlAttribute(AttributeName = "roletype")]
        public string Roletype { get; set; }
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }
        [XmlAttribute(AttributeName = "bundleversion")]
        public string Bundleversion { get; set; }
        [XmlAttribute(AttributeName = "rolesourcebundlename")]
        public string Rolesourcebundlename { get; set; }
    }

    [XmlRoot(ElementName = "executionstrategy")]
    public class Executionstrategy
    {
        [XmlAttribute(AttributeName = "workersize")]
        public string Workersize { get; set; }
        [XmlAttribute(AttributeName = "strategy")]
        public string Strategy { get; set; }
    }

    [XmlRoot(ElementName = "mastermonitorconfig")]
    public class Mastermonitorconfig
    {
        [XmlElement(ElementName = "hostexpr")]
        public Hostexpr Hostexpr { get; set; }
        [XmlElement(ElementName = "targetexpr")]
        public Targetexpr Targetexpr { get; set; }
        [XmlElement(ElementName = "config")]
        public Config Config { get; set; }
        [XmlElement(ElementName = "executionstrategy")]
        public Executionstrategy Executionstrategy { get; set; }
        [XmlAttribute(AttributeName = "paused")]
        public string Paused { get; set; }
        [XmlAttribute(AttributeName = "scheduleref")]
        public string Scheduleref { get; set; }
        [XmlAttribute(AttributeName = "timeout")]
        public string Timeout { get; set; }
        [XmlAttribute(AttributeName = "desc")]
        public string Desc { get; set; }
    }

    [XmlRoot(ElementName = "mastermonitor")]
    public class Mastermonitor
    {
        [XmlElement(ElementName = "mastermonitorconfig")]
        public Mastermonitorconfig Mastermonitorconfig { get; set; }
        [XmlElement(ElementName = "measures")]
        public Measures Measures { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "item")]
    public class Item
    {
        [XmlAttribute(AttributeName = "optional")]
        public string Optional { get; set; }
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
        [XmlAttribute(AttributeName = "key")]
        public string Key { get; set; }
    }

    [XmlRoot(ElementName = "mastermonitors")]
    public class Mastermonitors
    {
        [XmlElement(ElementName = "mastermonitor")]
        public List<Mastermonitor> Mastermonitor { get; set; }
        [XmlAttribute(AttributeName = "rev")]
        public string Rev { get; set; }
    }

    [XmlRoot(ElementName = "testsconfiguration")]
    public class Testsconfiguration
    {
        [XmlAttribute(AttributeName = "upperlimitviolations")]
        public string Upperlimitviolations { get; set; }
        [XmlAttribute(AttributeName = "autoacceptimprovedruns")]
        public string Autoacceptimprovedruns { get; set; }
        [XmlAttribute(AttributeName = "lowerlimitviolations")]
        public string Lowerlimitviolations { get; set; }
        [XmlAttribute(AttributeName = "notifyvolatilerun")]
        public string Notifyvolatilerun { get; set; }
        [XmlAttribute(AttributeName = "visitbasedtestrunscreated")]
        public string Visitbasedtestrunscreated { get; set; }
        [XmlAttribute(AttributeName = "volatilepercent")]
        public string Volatilepercent { get; set; }
        [XmlAttribute(AttributeName = "falsepositivepercent")]
        public string Falsepositivepercent { get; set; }
        [XmlAttribute(AttributeName = "notifyimprovedrun")]
        public string Notifyimprovedrun { get; set; }
        [XmlAttribute(AttributeName = "requiredcalibrationruns")]
        public string Requiredcalibrationruns { get; set; }
        [XmlAttribute(AttributeName = "enableautotimers")]
        public string Enableautotimers { get; set; }
        [XmlAttribute(AttributeName = "notifyfailingrun")]
        public string Notifyfailingrun { get; set; }
        [XmlAttribute(AttributeName = "notifydegradedrun")]
        public string Notifydegradedrun { get; set; }
        [XmlAttribute(AttributeName = "bufferlength")]
        public string Bufferlength { get; set; }
    }

    [XmlRoot(ElementName = "incidentdowntimerefs")]
    public class Incidentdowntimerefs
    {
        [XmlAttribute(AttributeName = "rev")]
        public string Rev { get; set; }
    }

    [XmlRoot(ElementName = "systemprofile")]
    public class Systemprofile
    {
        [XmlElement(ElementName = "technology")]
        public List<Technology> Technology { get; set; }
        [XmlElement(ElementName = "sensorgroups")]
        public Sensorgroups Sensorgroups { get; set; }
        [XmlElement(ElementName = "measures")]
        public Measures Measures { get; set; }
        [XmlElement(ElementName = "schedules")]
        public Schedules Schedules { get; set; }
        [XmlElement(ElementName = "tasks")]
        public Tasks Tasks { get; set; }
        [XmlElement(ElementName = "monitors")]
        public Monitors Monitors { get; set; }
        [XmlElement(ElementName = "configurations")]
        public Configurations Configurations { get; set; }
        [XmlElement(ElementName = "uemconfiguration")]
        public Uemconfiguration Uemconfiguration { get; set; }
        [XmlElement(ElementName = "dataprivacyconfiguration")]
        public Dataprivacyconfiguration Dataprivacyconfiguration { get; set; }
        [XmlElement(ElementName = "customtierconfig")]
        public string Customtierconfig { get; set; }
        [XmlElement(ElementName = "dcrumconfig")]
        public Dcrumconfig Dcrumconfig { get; set; }
        [XmlElement(ElementName = "casuemdataexport")]
        public Casuemdataexport Casuemdataexport { get; set; }
        [XmlElement(ElementName = "genericagentproperties")]
        public Genericagentproperties Genericagentproperties { get; set; }
        [XmlElement(ElementName = "transactions")]
        public Transactions Transactions { get; set; }
        [XmlElement(ElementName = "incidentrules")]
        public Incidentrules Incidentrules { get; set; }
        [XmlElement(ElementName = "browserdiagnosticsconfig")]
        public string Browserdiagnosticsconfig { get; set; }
        [XmlElement(ElementName = "mastermonitors")]
        public Mastermonitors Mastermonitors { get; set; }
        [XmlElement(ElementName = "testsconfiguration")]
        public Testsconfiguration Testsconfiguration { get; set; }
        [XmlElement(ElementName = "incidentdowntimerefs")]
        public Incidentdowntimerefs Incidentdowntimerefs { get; set; }
        [XmlAttribute(AttributeName = "gomezconvergenceid")]
        public string Gomezconvergenceid { get; set; }
        [XmlAttribute(AttributeName = "repositoryaccess")]
        public string Repositoryaccess { get; set; }
        [XmlAttribute(AttributeName = "analyticsstream")]
        public string Analyticsstream { get; set; }
        [XmlAttribute(AttributeName = "description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "capture")]
        public string Capture { get; set; }
        [XmlAttribute(AttributeName = "sysprofgenerated")]
        public string Sysprofgenerated { get; set; }
        [XmlAttribute(AttributeName = "modifiedby")]
        public string Modifiedby { get; set; }
        [XmlAttribute(AttributeName = "initbtconfig")]
        public string Initbtconfig { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "architecture")]
        public string Architecture { get; set; }
    }

    [XmlRoot(ElementName = "dynatrace")]
    public class Dynatrace
    {
        [XmlElement(ElementName = "systemprofile")]
        public Systemprofile Systemprofile { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }
    
}
