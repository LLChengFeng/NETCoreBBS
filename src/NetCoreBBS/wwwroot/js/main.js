$(document).ready(function () {
    L2Dwidget.init({
        model: {
            jsonPath: 'https://unpkg.com/live2d-widget-model-shizuku@1.0.5/assets/shizuku.model.json',
        },
        display: {
            superSample: 1.5,
            width: 150,
            height: 300,
            position: 'right',
            hOffset: 0,
            vOffset: -20,
        },
        mobile: {
            show: true,
            scale: 0.5,
            motion: true,
        },
        react: {
            opacityDefault: 0.7,
            opacityOnHover: 0.2,
        }
    });
});