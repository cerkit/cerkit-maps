function initMap(shapePath) {
	DevExpress.viz.vectormaputils.parse(shapePath, { precision: 4 }, function (data) {
        $('#mapContainer').dxVectorMap({
        	bounds: [data.bbox[0] - 2.8, data.bbox[1] - 3, data.bbox[2] - 0.25, data.bbox[3] + 3],
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