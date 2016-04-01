function initMap(shapeUrl) {

    $.getJSON(shapeUrl, function (shapeViewModel) {
        var shapeBuffer = _base64ToArrayBuffer(shapeViewModel.shape),
        dbfBuffer = _base64ToArrayBuffer(shapeViewModel.dbf);
        var parseSources = { shp: shapeBuffer, dbf: dbfBuffer },
        parseOptions = { precision: 4 },
        data = DevExpress.viz.vectormaputils.parse(parseSources, parseOptions);

        $('#mapContainer').dxVectorMap({
            zoomFactor: 3,
            layers: [{
                type: 'area',
                data: data,
                color: '#CCFFCC',
                hoveredColor: '#AAFFAA',
                borderColor: '#999999'
            }]
        });
    });
}

function _base64ToArrayBuffer(base64) {
    var binary_string = window.atob(base64);
    var len = binary_string.length;
    var bytes = new Uint8Array(len);
    for (var i = 0; i < len; i++) {
        bytes[i] = binary_string.charCodeAt(i);
    }
    return bytes.buffer;
}