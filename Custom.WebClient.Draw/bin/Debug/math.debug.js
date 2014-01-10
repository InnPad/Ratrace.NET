//! math.debug.js
//

(function($) {

Type.registerNamespace('Custom');

////////////////////////////////////////////////////////////////////////////////
// Custom.Epsilon

Custom.Epsilon = function Custom_Epsilon() {
    /// <field name="value" type="Number" static="true">
    /// </field>
}


////////////////////////////////////////////////////////////////////////////////
// Custom.PI

Custom.PI = function Custom_PI() {
    /// <field name="value" type="Number" static="true">
    /// </field>
    /// <field name="twice" type="Number" static="true">
    /// </field>
    /// <field name="half" type="Number" static="true">
    /// </field>
}


////////////////////////////////////////////////////////////////////////////////
// Custom.GoldenRatio

Custom.GoldenRatio = function Custom_GoldenRatio() {
    /// <field name="value" type="Number" static="true">
    /// </field>
    /// <field name="inverse" type="Number" static="true">
    /// </field>
}


////////////////////////////////////////////////////////////////////////////////
// Custom.Pythagoras

Custom.Pythagoras = function Custom_Pythagoras() {
    /// <summary>
    /// Pitagoras Constant
    /// </summary>
    /// <field name="value" type="Number" static="true">
    /// </field>
    /// <field name="half" type="Number" static="true">
    /// </field>
}


Custom.Epsilon.registerClass('Custom.Epsilon');
Custom.PI.registerClass('Custom.PI');
Custom.GoldenRatio.registerClass('Custom.GoldenRatio');
Custom.Pythagoras.registerClass('Custom.Pythagoras');
Custom.Epsilon.value = 1E-10;
Custom.PI.value = Math.PI;
Custom.PI.twice = 2 * Custom.PI.value;
Custom.PI.half = Custom.PI.value / 2;
Custom.GoldenRatio.value = (1 + Math.sqrt(5)) / 2;
Custom.GoldenRatio.inverse = 1 / Custom.GoldenRatio.value;
Custom.Pythagoras.value = Math.sqrt(2);
Custom.Pythagoras.half = Custom.Pythagoras.value / 2;
})(jQuery);

//! This script was generated using Script# v0.7.4.0
