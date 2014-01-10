require.config({
    waitSeconds: 5,
    paths: {
        angular: '//ajax.googleapis.com/ajax/libs/angularjs/1.0.3/angular.min',
        base: 'base.debug',
        core: 'core.debug',
        demo: 'demo.debug',
        draw: 'draw.debug',
        jquery: '//ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min',
        'jquery.mobile': '//jquerymobile.com/demos/1.2.0/js/jquery.mobile-1.2.0',
        'jquery.mobile-adapter': '//github.com/tigbro/jquery-mobile-angular-adapter/raw/master/compiled/jquery-mobile-angular-adapter-1.1.1',
        'jquery-ui': '//ajax.googleapis.com/ajax/libs/jqueryui/1.10.1/jquery-ui.min',
        'kinetic': 'kinetic-v4.3.3',
        main: 'main.debug',
        math: 'math.debug',
        mscorlib: 'mscorlib.debug',
        reflection: 'reflection.debug',
        social: 'social.debug',
        trading: 'trading.debug',

        jslider: "/jslider/jquery.slider",
        draggable: "/jslider/draggable-0.1",
        numberFormatter: "/jslider/jquery.numberformatter-1.2.3",
        jshashtable: "/jslider/jshashtable-2.1_src",
    },
    priority: ['mscorlib', 'jquery', 'angular'],
    shim: {
        angular: { deps: ['jquery'], exports: 'angular' },
        base: { deps: ['mscorlib', 'jquery'] },
        core: { deps: ['mscorlib', 'jquery', 'base'] },
        demo: { deps: ['mscorlib', 'jquery', 'base', 'draw', 'kinetic'] },
        draw: { deps: ['mscorlib', 'jquery', 'base', 'kinetic', 'math'] },
        //jquery: { exports: '$' },
        'jquery.mobile': { deps: ['jquery', 'jquery-ui'] },
        'jquery.mobile-adapter': { deps: ['jquery', 'angular'] },
        'jquery-ui': { deps: ['jquery'] },
        main: { deps: ['mscorlib', 'jquery', 'base', 'core', 'angular'] },
        math: { deps: ['mscorlib', 'jquery', 'base'] },
        reflection: { deps: ['mscorlib', 'jquery', 'base', 'core', 'angular'] },
        social: { deps: ['mscorlib', 'jquery', 'base', 'core', 'angular'] },
        trading: { deps: ['mscorlib', 'jquery', 'base', 'core', 'main', 'kinetic', 'angular'] },
        jslider: { deps: ['jquery', 'draggable', 'numberFormatter', 'jshashtable'] }
    }
});

function tryHoldReady() {
    if (!tryHoldReady.executed && window.jQuery) {
        window.jQuery.holdReady(true);
        tryHoldReady.executed = true;
    }
}

tryHoldReady();
require.onResourceLoad = tryHoldReady;

require([
    'jquery',
    'jquery-ui',
    'jquery.mobile-adapter',
    'jquery.mobile-external-pages',
    /*'jslider',*/
    'main'
], function (jquery) {
    jquery.holdReady(false);
});